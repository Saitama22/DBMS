
namespace dbms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbDatabase = new System.Windows.Forms.ComboBox();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.ButRunq = new System.Windows.Forms.Button();
            this.DataView2 = new System.Windows.Forms.DataGridView();
            this.ButAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusL1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.butDelRows = new System.Windows.Forms.Button();
            this.GridCreate = new System.Windows.Forms.DataGridView();
            this.butCreate = new System.Windows.Forms.Button();
            this.listBoxTypes = new System.Windows.Forms.ListBox();
            this.tbCreateTable = new System.Windows.Forms.TextBox();
            this.butDelTable = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabRead = new System.Windows.Forms.TabPage();
            this.ClbColumns = new System.Windows.Forms.CheckedListBox();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tabRedactTable = new System.Windows.Forms.TabPage();
            this.lbselectType = new System.Windows.Forms.ListBox();
            this.butRedactTable = new System.Windows.Forms.Button();
            this.GridRedactTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.tabRead.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabRedactTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRedactTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbDatabase
            // 
            this.CbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDatabase.FormattingEnabled = true;
            this.CbDatabase.Location = new System.Drawing.Point(3, 3);
            this.CbDatabase.Name = "CbDatabase";
            this.CbDatabase.Size = new System.Drawing.Size(121, 21);
            this.CbDatabase.TabIndex = 0;
            this.CbDatabase.SelectedIndexChanged += new System.EventHandler(this.CbDatabase_SelectedIndexChanged);
            this.CbDatabase.Click += new System.EventHandler(this.CbDatabase_Click);
            // 
            // DataView
            // 
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(3, 137);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(321, 230);
            this.DataView.TabIndex = 2;
            this.DataView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataView_CellBeginEdit);
            this.DataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellClick);
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick_1);
            // 
            // ButRunq
            // 
            this.ButRunq.Location = new System.Drawing.Point(3, 108);
            this.ButRunq.Name = "ButRunq";
            this.ButRunq.Size = new System.Drawing.Size(75, 23);
            this.ButRunq.TabIndex = 4;
            this.ButRunq.Text = "Запустить";
            this.ButRunq.UseVisualStyleBackColor = true;
            this.ButRunq.Click += new System.EventHandler(this.ButRunq_Click);
            // 
            // DataView2
            // 
            this.DataView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView2.Location = new System.Drawing.Point(12, 5);
            this.DataView2.Name = "DataView2";
            this.DataView2.Size = new System.Drawing.Size(299, 201);
            this.DataView2.TabIndex = 5;
            // 
            // ButAdd
            // 
            this.ButAdd.Location = new System.Drawing.Point(12, 212);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(110, 48);
            this.ButAdd.TabIndex = 6;
            this.ButAdd.Text = "Добавить";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusL1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1074, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusL1
            // 
            this.StatusL1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusL1.Name = "StatusL1";
            this.StatusL1.Size = new System.Drawing.Size(94, 21);
            this.StatusL1.Text = "Все хорошо";
            // 
            // butDelRows
            // 
            this.butDelRows.Location = new System.Drawing.Point(3, 373);
            this.butDelRows.Name = "butDelRows";
            this.butDelRows.Size = new System.Drawing.Size(99, 44);
            this.butDelRows.TabIndex = 9;
            this.butDelRows.Text = "Обновить";
            this.butDelRows.UseVisualStyleBackColor = true;
            this.butDelRows.Click += new System.EventHandler(this.butDelRows_Click);
            // 
            // GridCreate
            // 
            this.GridCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCreate.Location = new System.Drawing.Point(3, 34);
            this.GridCreate.Name = "GridCreate";
            this.GridCreate.Size = new System.Drawing.Size(254, 230);
            this.GridCreate.TabIndex = 10;
            this.GridCreate.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCreate_CellEnter);
            this.GridCreate.SelectionChanged += new System.EventHandler(this.GridCreate_SelectionChanged);
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(3, 270);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(114, 37);
            this.butCreate.TabIndex = 12;
            this.butCreate.Text = "Создать";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // listBoxTypes
            // 
            this.listBoxTypes.FormattingEnabled = true;
            this.listBoxTypes.Items.AddRange(new object[] {
            "Int",
            "Float",
            "Nvarchar(50)",
            "DateTime",
            "Bit"});
            this.listBoxTypes.Location = new System.Drawing.Point(256, 34);
            this.listBoxTypes.Name = "listBoxTypes";
            this.listBoxTypes.Size = new System.Drawing.Size(91, 69);
            this.listBoxTypes.TabIndex = 14;
            this.listBoxTypes.Visible = false;
            this.listBoxTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxTypes_SelectedIndexChanged);
            this.listBoxTypes.Leave += new System.EventHandler(this.listBoxTypes_Leave);
            // 
            // tbCreateTable
            // 
            this.tbCreateTable.Location = new System.Drawing.Point(69, 8);
            this.tbCreateTable.Name = "tbCreateTable";
            this.tbCreateTable.Size = new System.Drawing.Size(100, 20);
            this.tbCreateTable.TabIndex = 15;
            // 
            // butDelTable
            // 
            this.butDelTable.Location = new System.Drawing.Point(3, 170);
            this.butDelTable.Name = "butDelTable";
            this.butDelTable.Size = new System.Drawing.Size(137, 36);
            this.butDelTable.TabIndex = 18;
            this.butDelTable.Text = "Удалить";
            this.butDelTable.UseVisualStyleBackColor = true;
            this.butDelTable.Click += new System.EventHandler(this.butDelTable_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(22, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.butDelTable);
            this.splitContainer1.Panel1.Controls.Add(this.lbTables);
            this.splitContainer1.Panel1.Controls.Add(this.CbDatabase);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(898, 478);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Таблицы";
            // 
            // lbTables
            // 
            this.lbTables.FormattingEnabled = true;
            this.lbTables.Location = new System.Drawing.Point(3, 43);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(150, 121);
            this.lbTables.TabIndex = 21;
            this.lbTables.SelectedIndexChanged += new System.EventHandler(this.lbTables_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCreate);
            this.tabControl1.Controls.Add(this.tabRead);
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabRedactTable);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.label2);
            this.tabCreate.Controls.Add(this.GridCreate);
            this.tabCreate.Controls.Add(this.butCreate);
            this.tabCreate.Controls.Add(this.listBoxTypes);
            this.tabCreate.Controls.Add(this.tbCreateTable);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(700, 449);
            this.tabCreate.TabIndex = 0;
            this.tabCreate.Text = "Создание таблицы";
            this.tabCreate.UseVisualStyleBackColor = true;
            this.tabCreate.Click += new System.EventHandler(this.tabCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Название";
            // 
            // tabRead
            // 
            this.tabRead.Controls.Add(this.ClbColumns);
            this.tabRead.Controls.Add(this.DataView);
            this.tabRead.Controls.Add(this.ButRunq);
            this.tabRead.Controls.Add(this.butDelRows);
            this.tabRead.Location = new System.Drawing.Point(4, 22);
            this.tabRead.Name = "tabRead";
            this.tabRead.Padding = new System.Windows.Forms.Padding(3);
            this.tabRead.Size = new System.Drawing.Size(700, 449);
            this.tabRead.TabIndex = 1;
            this.tabRead.Text = "Чтение данных";
            this.tabRead.UseVisualStyleBackColor = true;
            this.tabRead.Enter += new System.EventHandler(this.tabRead_Enter);
            // 
            // ClbColumns
            // 
            this.ClbColumns.CheckOnClick = true;
            this.ClbColumns.FormattingEnabled = true;
            this.ClbColumns.Location = new System.Drawing.Point(3, 8);
            this.ClbColumns.Name = "ClbColumns";
            this.ClbColumns.Size = new System.Drawing.Size(120, 94);
            this.ClbColumns.TabIndex = 10;
            this.ClbColumns.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbColumns_ItemCheck);
            this.ClbColumns.SelectedIndexChanged += new System.EventHandler(this.ClbColumns_SelectedIndexChanged);
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.DataView2);
            this.tabAdd.Controls.Add(this.ButAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Size = new System.Drawing.Size(700, 449);
            this.tabAdd.TabIndex = 2;
            this.tabAdd.Text = "Добавление данных";
            this.tabAdd.UseVisualStyleBackColor = true;
            this.tabAdd.Enter += new System.EventHandler(this.tabAdd_Enter);
            // 
            // tabRedactTable
            // 
            this.tabRedactTable.Controls.Add(this.lbselectType);
            this.tabRedactTable.Controls.Add(this.butRedactTable);
            this.tabRedactTable.Controls.Add(this.GridRedactTable);
            this.tabRedactTable.Location = new System.Drawing.Point(4, 22);
            this.tabRedactTable.Name = "tabRedactTable";
            this.tabRedactTable.Size = new System.Drawing.Size(700, 449);
            this.tabRedactTable.TabIndex = 3;
            this.tabRedactTable.Text = "Изменение таблицы";
            this.tabRedactTable.UseVisualStyleBackColor = true;
            this.tabRedactTable.Click += new System.EventHandler(this.tabRedactTable_Click);
            this.tabRedactTable.Enter += new System.EventHandler(this.tabRedactTable_Enter);
            // 
            // lbselectType
            // 
            this.lbselectType.FormattingEnabled = true;
            this.lbselectType.Items.AddRange(new object[] {
            "Int",
            "Float",
            "Nvarchar(50)",
            "DateTime",
            "Bit"});
            this.lbselectType.Location = new System.Drawing.Point(244, 5);
            this.lbselectType.Name = "lbselectType";
            this.lbselectType.Size = new System.Drawing.Size(91, 69);
            this.lbselectType.TabIndex = 21;
            this.lbselectType.Visible = false;
            this.lbselectType.SelectedIndexChanged += new System.EventHandler(this.lbselectType_SelectedIndexChanged);
            // 
            // butRedactTable
            // 
            this.butRedactTable.Location = new System.Drawing.Point(3, 161);
            this.butRedactTable.Name = "butRedactTable";
            this.butRedactTable.Size = new System.Drawing.Size(122, 40);
            this.butRedactTable.TabIndex = 1;
            this.butRedactTable.Text = "Сохранить";
            this.butRedactTable.UseVisualStyleBackColor = true;
            this.butRedactTable.Click += new System.EventHandler(this.butRedactTable_Click);
            // 
            // GridRedactTable
            // 
            this.GridRedactTable.AllowUserToDeleteRows = false;
            this.GridRedactTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRedactTable.Location = new System.Drawing.Point(3, 5);
            this.GridRedactTable.Name = "GridRedactTable";
            this.GridRedactTable.Size = new System.Drawing.Size(240, 150);
            this.GridRedactTable.TabIndex = 0;
            this.GridRedactTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRedactTable_CellClick);
            this.GridRedactTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRedactTable_CellEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Text = "...";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 542);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "СУБД";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCreate)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
            this.tabRead.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabRedactTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridRedactTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbDatabase;
        private System.Windows.Forms.Button ButRunq;
        private System.Windows.Forms.DataGridView DataView2;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusL1;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button butDelRows;
        private System.Windows.Forms.DataGridView GridCreate;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.ListBox listBoxTypes;
        private System.Windows.Forms.TextBox tbCreateTable;
        private System.Windows.Forms.Button butDelTable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.TabPage tabRead;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabRedactTable;
        private System.Windows.Forms.Button butRedactTable;
        private System.Windows.Forms.DataGridView GridRedactTable;
        private System.Windows.Forms.CheckedListBox ClbColumns;
        private System.Windows.Forms.ListBox lbselectType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

