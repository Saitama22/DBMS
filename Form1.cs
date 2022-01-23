using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms
{
    public partial class Form1 : Form
    {
        Bd bd;
        string databaseName;
        string tableName;
        List<object> redactList = new List<object>();
        (int, int) selectCell;
        (int, int) selectCellRedact;
        public Form1()
        {
            InitializeComponent();
            databaseName = "adonetdb";
            tableName = "Users";
            bd = new Bd();
            bd.setDb(databaseName);
        }

        void SetTableCreate()
        {
            GridCreate.Columns.Clear();
            GridCreate.Columns.Add("", "Name");
            GridCreate.Columns.Add("", "Type");
            GridCreate.Rows.Add("Id", "int");
            GridCreate.Columns[1].ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CbDatabase.SelectedIndex = 
            lbTables.Items.Clear();
            lbTables.Items.AddRange(bd.getNameTables(databaseName).ToArray());

            SetTableCreate();
        }

        private void CbDatabase_Click(object sender, EventArgs e)
        {
            CbDatabase.Items.Clear();
            CbDatabase.Items.AddRange(bd.getNameBases().ToArray());
        }

        private void CbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            databaseName = CbDatabase.SelectedItem.ToString();
            lbTables.Items.Clear();
            lbTables.Items.AddRange(bd.getNameTables(databaseName).ToArray());
        }

        private void ButRunq_Click(object sender, EventArgs e)
        {
            object show = ClbColumns.CheckedItems;
            DataView.Columns.Clear();
            List<object> listCols = new List<object>();
            foreach (var item in ClbColumns.CheckedItems)
            {
                listCols.Add(item);
            }
            List<List<object>> result = new List<List<object>>();
            try
            {
                result = bd.getData(tableName, listCols);
            }
            catch (Exception)
            {
                StatusL1.Text = "Ошибка";
                return;
            }                
            try
            {
                object[] names = result[0].ToArray();
            }
            catch (Exception)
            {
                StatusL1.Text = "Ошибка";
                return;
            }
            StatusL1.Text = "Данные выведены.";
            for (int i = 0; i < result[0].Count; i++)
            {
                DataView.Columns.Add("",result[0][i].ToString());
            }
            DataView.Columns.Add("", "Del");
            DataView.Columns[0].ReadOnly = true;
            DataView.Columns[DataView.Columns.Count-1].ReadOnly = true;
            for (int i = 1; i < result.Count; i++)
            {
                DataView.Rows.Add(result[i].ToArray());
            }
        }

        private void TbSqlQuery_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButOpen_Click(object sender, EventArgs e)
        {
            //DataView2.Columns.Clear();            
            //List<object> result = bd.getNameCols(tableName);
            //for (int i = 0; i < result.Count; i++)
            //{
            //    DataView2.Columns.Add("", result[i].ToString());
            //}
            
        }

        private void ButAdd_Click(object sender, EventArgs e)
        {
            List<List<object>> TempTable = new List<List<object>>();
            if (DataView2.Rows.Count - 1 < 1)
            {
                StatusL1.Text = "Ошибка в заполнении таблицы!";
                return;
            }            
            for (int i = 0; i < DataView2.Rows.Count-1; i++)
            {
                List<object> row = new List<object>();
                for (int j = 0; j < DataView2.Columns.Count; j++)
                {
                    row.Add(DataView2.Rows[i].Cells[j].Value);
                }
                TempTable.Add(row);
            }
            try
            {
                bd.putValues(tableName, TempTable);
            }
            catch (Exception)
            {
                StatusL1.Text = "Ошибка в заполнении таблицы!";
                return;
            }
            StatusL1.Text = "Все Хорошо";
        }

        private void DataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataView.Columns.Count - 1 && e.RowIndex !=-1)
                if (DataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                    DataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Y";
                else
                DataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
        }

        private void butDelRows_Click(object sender, EventArgs e)
        {
            List<object> listDel = new List<object>();
            List<List<object>> RowRedact = new List<List<object>>();
            for (int i = 0; i < DataView.Rows.Count; i++)
            {
                if (DataView.Rows[i].Cells[DataView.Columns.Count - 1].Value != null)
                    listDel.Add(DataView.Rows[i].Cells[0].Value);
            }
            foreach (var item in redactList)
            {
                List<object> row = new List<object>();
                for (int i = 0; i < DataView.Columns.Count-1; i++)
                {
                    row.Add(DataView.Rows[(int)item].Cells[i].Value);
                }
                RowRedact.Add(row);
            }
            try
            {
                bd.delData(tableName, DataView.Columns[0].HeaderText, listDel);
            }
            catch (Exception)
            {
                StatusL1.Text = "Ошибка.";
                return;
            }
            try
            {
                List<object> namesCols = new List<object>();
                for (int i = 0; i < DataView.Columns.Count-1; i++)
                {
                    namesCols.Add(DataView.Columns[i].HeaderText);
                }                 
                 bd.updata(RowRedact, namesCols, tableName);
            }
            catch (Exception)
            {
                StatusL1.Text = "Ошибка.";
                return;
            }
            StatusL1.Text = "Данные изменены.";
            DataView.Columns.Clear();
        }

  

        private void DataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!redactList.Contains(e.RowIndex))
                redactList.Add(e.RowIndex);
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridCreate.Rows[selectCell.Item2].Cells[selectCell.Item1].Value = listBoxTypes.SelectedItem;
        }
        private void GridCreate_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==1 && e.RowIndex!=0)
            {
                listBoxTypes.Visible = true;
                selectCell.Item1 = e.ColumnIndex;
                selectCell.Item2 = e.RowIndex;
            }                          
            else
                listBoxTypes.Visible = false;
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            List<(object, object)> listCols = new List<(object, object)>();
            for (int i = 0; i < GridCreate.Rows.Count-1; i++)
            {
                listCols.Add ((GridCreate.Rows[i].Cells[0].Value, GridCreate.Rows[i].Cells[1].Value));
            }
            try
            {
                bd.createTable(listCols, tbCreateTable.Text);
            }
            catch (Exception)
            {
                StatusL1.Text = "Нет названия или неправильное заполнение";
                return;
            }
            StatusL1.Text = "Таблица создана";
            lbTables.Items.Clear();
            lbTables.Items.AddRange(bd.getNameTables(databaseName).ToArray());
            SetTableCreate();
        }

        private void GridCreate_SelectionChanged(object sender, EventArgs e)
        {
            //listBoxTypes.Visible = false;
        }

        private void listBoxTypes_Leave(object sender, EventArgs e)
        {
            listBoxTypes.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        void SetTabRead()
        {
            List<(object, object)> res = bd.getinfotable(tableName);
            ClbColumns.Items.Clear();
            bool ch = true;
            foreach (var item in res)
            {
                ClbColumns.Items.Add(item.Item1.ToString(), ch);//+ " ("+ item.Item2.ToString()+")",ch
                ch = false;
            }
        }
        void SetTabAdd()
        {
            DataView2.Columns.Clear();
            List<object> result = bd.getNameCols(tableName);
            for (int i = 0; i < result.Count; i++)
            {
                DataView2.Columns.Add("", result[i].ToString());
            }
        }
        void SetTabRedact()
        {
            GridRedactTable.Columns.Clear();
            List<(object, object)> resultat = bd.getinfotable(tableName);
            GridRedactTable.Columns.Add("", "Name");
            GridRedactTable.Columns.Add("", "Type");
            GridRedactTable.Columns.Add("", "Del");
            GridRedactTable.Columns[2].ReadOnly = true;
            GridRedactTable.Columns[1].ReadOnly = true;
            foreach (var item in resultat)
            {
                GridRedactTable.Rows.Add(item.Item1, item.Item2);
                //GridRedactTable.Rows.
            }
        }

        private void lbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTables.SelectedIndex == -1)
                return;
            tableName = lbTables.SelectedItem.ToString();
            this.Text = $"СУБД - {tableName}";

            SetTabRead();
            SetTabAdd();
            SetTabRedact();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabAdd_Enter(object sender, EventArgs e)
        {
            //DataView2.Columns.Clear();
            //List<object> result = bd.getNameCols(tableName);
            //for (int i = 0; i < result.Count; i++)
            //{
            //    DataView2.Columns.Add("", result[i].ToString());
            //}
        }

        private void butDelTable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить таблицу?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                    bd.delTable(tableName);
            }
            catch (Exception)
            {
                StatusL1.Text = "Не выделена таблица";
                return;
            }
            StatusL1.Text = "Таблица удалена";
            lbTables.Items.Clear();
            lbTables.Items.AddRange(bd.getNameTables(databaseName).ToArray());
            this.Text = "СУБД";
            SetTabRead();
            SetTabAdd();
            SetTabRedact();
        }

        private void tabRedactTable_Enter(object sender, EventArgs e)
        {
            //GridRedactTable.Columns.Clear();
            //List<(object,object)> res = bd.getinfotable(tableName);
            //GridRedactTable.Columns.Add("", "Name");
            //GridRedactTable.Columns.Add("", "Type");
            //GridRedactTable.Columns.Add("", "Del");
            //GridRedactTable.Columns[2].ReadOnly = true;
            //GridRedactTable.Columns[1].ReadOnly = true;
            //foreach (var item in res)
            //{
            //    GridRedactTable.Rows.Add(item.Item1, item.Item2);
            //}
            

        }

        private void tabCreate_Click(object sender, EventArgs e)
        {

        }

        private void GridRedactTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridRedactTable.Columns.Count - 1 && e.RowIndex != -1)
                if (GridRedactTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null && e.RowIndex != 0)
                    GridRedactTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Y";
                else
                    GridRedactTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
            

        }

        private void tabRead_Enter(object sender, EventArgs e)
        {
            //List<(object, object)> res = bd.getinfotable(tableName);
            //ClbColumns.Items.Clear();
            //bool ch = true;
            //foreach (var item in res)
            //{                
            //    ClbColumns.Items.Add(item.Item1.ToString(),ch );//+ " ("+ item.Item2.ToString()+")",ch
            //    ch = false;
            //}
            
        }

        private void ClbColumns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
                e.NewValue = CheckState.Checked;
        }

        private void ClbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void tabRedactTable_Click(object sender, EventArgs e)
        {

        }

        private void DataView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void lbselectType_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if(selectCellRedact.Item1 != 0 && selectCellRedact.Item2 != 0)
                GridRedactTable.Rows[selectCellRedact.Item2].Cells[selectCellRedact.Item1].Value = lbselectType.SelectedItem;
        }

        private void GridRedactTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectCellRedact.Item1 = e.ColumnIndex;
            selectCellRedact.Item2 = e.RowIndex;
            if (e.ColumnIndex == 1 && e.RowIndex != 0)
            {
                lbselectType.Visible = true;                
            }
            else
                lbselectType.Visible = false;
        }

        private void butRedactTable_Click(object sender, EventArgs e)
        {
            int colCount = bd.getNameCols(tableName).Count()+1;
            List<object> listDel = new List<object>();
            for (int i = 0; i < colCount; i++)
            {
                if (GridRedactTable.Rows[i].Cells[2].Value != null)
                    listDel.Add(GridRedactTable.Rows[i].Cells[0].Value.ToString());
            }
            List<object> listAdd = new List<object>();
            for (int i = colCount; i < GridRedactTable.Rows.Count-1; i++)
                listAdd.Add(GridRedactTable.Rows[i].Cells[0].Value.ToString() + " " + GridRedactTable.Rows[i].Cells[1].Value.ToString());
            bd.alterTable(tableName, listAdd, listDel);
            GridRedactTable.Columns.Clear();
        }
    }
}
