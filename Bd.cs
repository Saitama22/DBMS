using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace dbms
{
    class Bd
    {
        SqlConnection connection;
        string connectionstr;
        public Bd()
        {
            connectionstr = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=true";
            connect();
        }
        void connect()
        {            
            connection = new SqlConnection(connectionstr);
         //   connection.Open();
         //   connection.Close();
            //try
            //{
            //    await connection.OpenAsync();

            //}
            //catch (Exception ex)
            //{

            //}
            //finally
            //{
            //    Console.WriteLine("Программа завершила работу.");
            //}
        }

        public List<object> getNameBases()
        {
            connection.ConnectionString = connectionstr;
            using (connection)
            {
                connection.Open();
                List<object> listBases = new List<object>();
                string sqlExpr = "select name from sys.databases"; //"Select table_name from INFORMATION_SCHEMA.TABLES";
                SqlCommand command = new SqlCommand(sqlExpr, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object result = reader.GetValue(0);
                    listBases.Add(result);
                }
                connection.Close();
                return listBases;
            }
        }
        public void setDb(string bdName)
        {
            connectionstr = "Server=(localdb)\\mssqllocaldb;Database=" + bdName + ";Trusted_Connection=true";            
        }
        void optPars(SqlCommand command)
        {
            foreach (IDataParameter param in command.Parameters)
            {
                if (param.Value == null) param.Value = DBNull.Value;
            }
        }
        public List<object> getNameTables(string bdName)
        {
            //connectionstr = "Server=(localdb)\\mssqllocaldb;Database="+bdName+";Trusted_Connection=true";
            connection.ConnectionString = connectionstr;
            using (connection)
            {
                connection.Open();
                List<object> listtable = new List<object>();
                string sqlExpr = "Select table_name from INFORMATION_SCHEMA.TABLES";
                SqlCommand command = new SqlCommand(sqlExpr, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object result = reader.GetValue(0);
                    listtable.Add(result);
                }
                connection.Close();
                return listtable;
            }
        }
        public List<List<object>> getSqlquery(string query)
        {
            connection.ConnectionString = connectionstr;
            List<List<object>> result = new List<List<object>>();
            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    List<object> names = new List<object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        names.Add(reader.GetName(i));
                    }
                    result.Add(names);
                    while (reader.Read())
                    {
                        List<object> row = new List<object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetValue(i));
                        }
                        result.Add(row);
                    } // read
                    object ar = result.ToArray();
                } // reader.hasraws
                connection.Close();
            }
            return result;
        }
        public List<object> getNameCols(string TableName)
        {
            connection.ConnectionString = connectionstr;
            using (connection)
            {
                connection.Open();
                List<object> listtable = new List<object>();
                string sqlExpr = "SELECT CONCAT(sc.name, ' (', st.name, ')') FROM sys.columns as sc " +
                    "join sys.types as st on st.user_type_id = sc.user_type_id " +
                    "join INFORMATION_SCHEMA.KEY_COLUMN_USAGE as ik on ik.COLUMN_NAME != sc.name " +
                    $"WHERE object_id = OBJECT_ID('{TableName}') " +
                    $"and ik.table_name = '{TableName}'";
                SqlCommand command = new SqlCommand(sqlExpr, connection);
                SqlDataReader reader = command.ExecuteReader(); 
                while (reader.Read())
                {
                    object result = reader.GetValue(0);
                    listtable.Add(result);
                }
                connection.Close();
                return listtable;
            }
        }
        public object putValues(string tableName, List<List<object>> tempTable)
        {
            connection.ConnectionString = connectionstr;
            //using (connection)
            //{
            //    connection.Open();
            //    string sqlExpr = $"insert into {tableName} values ";
            //    string strValues = "";
            //    for (int i = 0; i < tempTable.Count; i++)
            //    {
            //        string tempstr = "(";
            //        for (int j = 0; j < tempTable[i].Count; j++)
            //        {
            //            tempstr += "'";
            //            if (tempTable[i][j] != null)
            //                tempstr += tempTable[i][j].ToString();
            //            else
            //                tempstr += "null";
            //            if (j != tempTable[i].Count - 1)
            //                tempstr += "',";
            //            else
            //                tempstr += "')";
            //        }
            //        if (i != tempTable.Count - 1)
            //            tempstr += ',';
            //        strValues += tempstr;
            //    }
            //    sqlExpr += strValues;
            //    SqlCommand command = new SqlCommand(sqlExpr, connection);
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //} 
            using (connection)
            {
                connection.Open();
                foreach (var item in tempTable)
                {
                    string sqlExpr = $"insert into {tableName} values (";
                    int i = 0;
                    List<SqlParameter> listPars = new List<SqlParameter>();
                    foreach (var val in item)
                    {
                        sqlExpr += "@v" + i.ToString();
                        if (i != item.Count-1)
                            sqlExpr += ", ";
                        listPars.Add(new SqlParameter("@v"+i.ToString(), val));
                        i++;
                        //command.Parameters.Add(parameter);
                    }
                    sqlExpr += ")";
                    SqlCommand command = new SqlCommand(sqlExpr, connection);
                    command.Parameters.AddRange(listPars.ToArray());
                    optPars(command);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return "";
        }
        public void delData(string TableName,string prKey,List<object> listDel)
        {
            connection.ConnectionString = connectionstr;
            using(connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                foreach (int item in listDel)
                {
                    SqlParameter parameter = new SqlParameter("@value", item.ToString());
                    string sqlExp = $"delete from {TableName} where { prKey} = @value";                    
                    command = new SqlCommand(sqlExp, connection);
                    command.Parameters.Add(parameter);
                    optPars(command);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void updata(List<List<object>> updata, List<object> nameCols,string TableName)
        {
            connection.ConnectionString = connectionstr;
            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                foreach (var item in updata)    
                {
                    for (int i = 1; i < item.Count; i++)
                    {
                        string sqlExp = $"update {TableName} set {nameCols[i]} = @value where {nameCols[0]} = @check"; 
                        command = new SqlCommand(sqlExp, connection);
                        //    SqlParameter colname = new SqlParameter("@column", nameCols[i].ToString());

                        SqlParameter value = new SqlParameter("@value", item[i]);
                        //   SqlParameter key = new SqlParameter("@key", nameCols[0].ToString());
                        SqlParameter check = new SqlParameter("@check", item[0]);
                      //  command.Parameters.AddRange(new SqlParameter[] {colname, value, key , check });
                        command.Parameters.AddRange(new SqlParameter[] {value, check});
                        optPars(command);
                        command.ExecuteNonQuery();
                    }                   
                }
                connection.Close();
            }
        }
        public void createTable(List<(object,object)> cols, string TableName)
        {
            connection.ConnectionString = connectionstr;
            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                string sqlExp = $"create table {TableName} (";
                int i=0;
                List<SqlParameter> listpars = new List<SqlParameter>();
                foreach (var item in cols)
                {
                  //  sqlExp += "@v" + i.ToString();
                    sqlExp += $"{item.Item1}";
                    listpars.Add(new SqlParameter("@v" + i.ToString(), item.Item1));
                    sqlExp += $" {item.Item2}";
                    if (i == 0)
                        sqlExp += " primary key IDENTITY ";
                    if (i != cols.Count - 1)
                        sqlExp += ",";
                    i++;
                }
                sqlExp += ")";
                command = new SqlCommand(sqlExp, connection);
                optPars(command);
                command.ExecuteNonQuery();
            }
        }
        public void delTable(string TableName)
        {
            connection.ConnectionString = connectionstr;
            using (connection)
            {
                connection.Open();
                string sqlExp = $"drop table {TableName}";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public List<(object, object)> getinfotable(string TableName)
        {
            connection.ConnectionString = connectionstr;
            using (connection)
            {
                connection.Open();
                List<(object,object)> listtable = new List<(object, object)>();
                string sqlExpr = "SELECT sc.name, st.name FROM sys.columns as sc " +
                    "join sys.types as st on st.user_type_id = sc.user_type_id " +
                    $"WHERE object_id = OBJECT_ID('{TableName}') ";
                SqlCommand command = new SqlCommand(sqlExpr, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object column = reader.GetValue(0);
                    object type = reader.GetValue(1);
                    listtable.Add((column,type));
                }
                connection.Close();
                return listtable;
            }
        }
        public List<List<object>> getData(string tableName, List<object> cols)
        {
            connection.ConnectionString = connectionstr;
            List<List<object>> result = new List<List<object>>();
            using (connection)
            {
                connection.Open();
                string sqlExp = $"select ";// * from {tableName}";
                foreach (var item in cols)
                {
                    sqlExp += item;
                    if (cols[cols.Count-1] != item)
                        sqlExp += ", ";
                }
                sqlExp += $" from {tableName}";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    List<object> names = new List<object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        names.Add(reader.GetName(i));
                    }
                    result.Add(names);
                    while (reader.Read())
                    {
                        List<object> row = new List<object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetValue(i));
                        }
                        result.Add(row);
                    } // read
                    object ar = result.ToArray();
                } // reader.hasraws
                connection.Close();
            }
            return result;
        }
        public void alterTable(string tablename, List<object> add, List<object> del)
        {
            connection.ConnectionString = connectionstr;
            using(connection)
            {
                connection.Open();
                string sqlExp = $"alter table {tablename} "; 
                if (add.Count!=0)
                {
                    sqlExp += "add ";
                    int i = 0;
                    List<SqlParameter> listPars = new List<SqlParameter>();
                    foreach (var item in add)
                    {
                        //sqlExp += "@v" + i.ToString() + " not null ";
                        sqlExp += item.ToString() + " null ";
                        if (i != add.Count - 1)
                            sqlExp += ", ";
                        //listPars.Add(new SqlParameter("@v" + i.ToString(), item));
                        i++;
                    }
                    sqlExp += ";";
                    SqlCommand command = new SqlCommand(sqlExp, connection);
                   // command.Parameters.AddRange(listPars.ToArray());
                    //optPars(command);
                    command.ExecuteNonQuery();
                }
                if (del.Count != 0)
                {
                    sqlExp += "drop column ";
                    int i = 0;
                    List<SqlParameter> listPars = new List<SqlParameter>();
                    foreach (var item in del)
                    {
                        //sqlExp += "@v" + i.ToString();
                        sqlExp += item.ToString();
                        if (i != del.Count - 1)
                            sqlExp += ", ";
                        //listPars.Add(new SqlParameter("@v" + i.ToString(), item));
                        i++;
                    }
                    sqlExp += ";";
                    SqlCommand command = new SqlCommand(sqlExp, connection);
                    //command.Parameters.AddRange(listPars.ToArray());
                    //optPars(command);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
