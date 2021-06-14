
namespace Ruslan.Форм
{
    partial class Заказзапчастей
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Заказзапчастей));
            this.lab2_1__1DataSet = new Ruslan.Lab2_1__1DataSet();
            this.zakaz_zapchasteyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakaz_zapchasteyTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.Zakaz_zapchasteyTableAdapter();
            this.tableAdapterManager = new Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager();
            this.zakaz_zapchasteyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.zakaz_zapchasteyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.zakaz_zapchasteyDataGridView = new System.Windows.Forms.DataGridView();
            this.prodajatovaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodaja_tovaraTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.Prodaja_tovaraTableAdapter();
            this.stranaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stranaTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.StranaTableAdapter();
            this.zapchastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zapchastTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.ZapchastTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Prodaja_tovara = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Stranyi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Zapchasti = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaz_zapchasteyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaz_zapchasteyBindingNavigator)).BeginInit();
            this.zakaz_zapchasteyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakaz_zapchasteyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajatovaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stranaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapchastBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lab2_1__1DataSet
            // 
            this.lab2_1__1DataSet.DataSetName = "Lab2_1__1DataSet";
            this.lab2_1__1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakaz_zapchasteyBindingSource
            // 
            this.zakaz_zapchasteyBindingSource.DataMember = "Zakaz_zapchastey";
            this.zakaz_zapchasteyBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // zakaz_zapchasteyTableAdapter
            // 
            this.zakaz_zapchasteyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrakTableAdapter = null;
            this.tableAdapterManager.Kategoria_postavshikaTableAdapter = null;
            this.tableAdapterManager.PostavshikTableAdapter = null;
            this.tableAdapterManager.Prodaja_tovaraTableAdapter = this.prodaja_tovaraTableAdapter;
            this.tableAdapterManager.SkidkiTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = this.stranaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vozvrat_brakaTableAdapter = null;
            this.tableAdapterManager.YacheykiTableAdapter = null;
            this.tableAdapterManager.Zakaz_zapchasteyTableAdapter = this.zakaz_zapchasteyTableAdapter;
            this.tableAdapterManager.ZapchastTableAdapter = this.zapchastTableAdapter;
            // 
            // zakaz_zapchasteyBindingNavigator
            // 
            this.zakaz_zapchasteyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zakaz_zapchasteyBindingNavigator.BindingSource = this.zakaz_zapchasteyBindingSource;
            this.zakaz_zapchasteyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zakaz_zapchasteyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zakaz_zapchasteyBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.zakaz_zapchasteyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.zakaz_zapchasteyBindingNavigatorSaveItem});
            this.zakaz_zapchasteyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zakaz_zapchasteyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zakaz_zapchasteyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zakaz_zapchasteyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zakaz_zapchasteyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zakaz_zapchasteyBindingNavigator.Name = "zakaz_zapchasteyBindingNavigator";
            this.zakaz_zapchasteyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zakaz_zapchasteyBindingNavigator.Size = new System.Drawing.Size(739, 27);
            this.zakaz_zapchasteyBindingNavigator.TabIndex = 0;
            this.zakaz_zapchasteyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // zakaz_zapchasteyBindingNavigatorSaveItem
            // 
            this.zakaz_zapchasteyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zakaz_zapchasteyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zakaz_zapchasteyBindingNavigatorSaveItem.Image")));
            this.zakaz_zapchasteyBindingNavigatorSaveItem.Name = "zakaz_zapchasteyBindingNavigatorSaveItem";
            this.zakaz_zapchasteyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.zakaz_zapchasteyBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.zakaz_zapchasteyBindingNavigatorSaveItem.Click += new System.EventHandler(this.zakaz_zapchasteyBindingNavigatorSaveItem_Click);
            // 
            // zakaz_zapchasteyDataGridView
            // 
            this.zakaz_zapchasteyDataGridView.AutoGenerateColumns = false;
            this.zakaz_zapchasteyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zakaz_zapchasteyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.ID_Prodaja_tovara,
            this.ID_Stranyi,
            this.ID_Zapchasti});
            this.zakaz_zapchasteyDataGridView.DataSource = this.zakaz_zapchasteyBindingSource;
            this.zakaz_zapchasteyDataGridView.Location = new System.Drawing.Point(0, 32);
            this.zakaz_zapchasteyDataGridView.Name = "zakaz_zapchasteyDataGridView";
            this.zakaz_zapchasteyDataGridView.RowHeadersWidth = 51;
            this.zakaz_zapchasteyDataGridView.RowTemplate.Height = 24;
            this.zakaz_zapchasteyDataGridView.Size = new System.Drawing.Size(613, 267);
            this.zakaz_zapchasteyDataGridView.TabIndex = 1;
            // 
            // prodajatovaraBindingSource
            // 
            this.prodajatovaraBindingSource.DataMember = "Prodaja_tovara";
            this.prodajatovaraBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // prodaja_tovaraTableAdapter
            // 
            this.prodaja_tovaraTableAdapter.ClearBeforeFill = true;
            // 
            // stranaBindingSource
            // 
            this.stranaBindingSource.DataMember = "Strana";
            this.stranaBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // stranaTableAdapter
            // 
            this.stranaTableAdapter.ClearBeforeFill = true;
            // 
            // zapchastBindingSource
            // 
            this.zapchastBindingSource.DataMember = "Zapchast";
            this.zapchastBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // zapchastTableAdapter
            // 
            this.zapchastTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Zapchasti";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Zapchasti";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naimenovanie_tovara";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naimenovanie_tovara";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kolichestvo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kolichestvo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pokupatel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pokupatel";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Naimenovanie_zapchastey";
            this.dataGridViewTextBoxColumn5.HeaderText = "Naimenovanie_zapchastey";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_Zakaz_zapchastey";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_Zakaz_zapchastey";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID_Prodaja_tovara";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID_Prodaja_tovara";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID_Stranyi";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID_Stranyi";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // ID_Prodaja_tovara
            // 
            this.ID_Prodaja_tovara.DataPropertyName = "ID_Prodaja_tovara";
            this.ID_Prodaja_tovara.DataSource = this.prodajatovaraBindingSource;
            this.ID_Prodaja_tovara.DisplayMember = "Summa";
            this.ID_Prodaja_tovara.HeaderText = "ID_Prodaja_tovara";
            this.ID_Prodaja_tovara.MinimumWidth = 6;
            this.ID_Prodaja_tovara.Name = "ID_Prodaja_tovara";
            this.ID_Prodaja_tovara.ValueMember = "ID_Prodaja_tovara";
            this.ID_Prodaja_tovara.Width = 125;
            // 
            // ID_Stranyi
            // 
            this.ID_Stranyi.DataPropertyName = "ID_Stranyi";
            this.ID_Stranyi.DataSource = this.stranaBindingSource;
            this.ID_Stranyi.DisplayMember = "Naimenovanie_stranyi";
            this.ID_Stranyi.HeaderText = "ID_Stranyi";
            this.ID_Stranyi.MinimumWidth = 6;
            this.ID_Stranyi.Name = "ID_Stranyi";
            this.ID_Stranyi.ValueMember = "ID_Stranyi";
            this.ID_Stranyi.Width = 125;
            // 
            // ID_Zapchasti
            // 
            this.ID_Zapchasti.DataPropertyName = "ID_Zapchasti";
            this.ID_Zapchasti.DataSource = this.zapchastBindingSource;
            this.ID_Zapchasti.DisplayMember = "Naimenovanie_zapchasti";
            this.ID_Zapchasti.HeaderText = "ID_Zapchasti";
            this.ID_Zapchasti.MinimumWidth = 6;
            this.ID_Zapchasti.Name = "ID_Zapchasti";
            this.ID_Zapchasti.ValueMember = "ID_Zapchasti";
            this.ID_Zapchasti.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.zakaz_zapchasteyBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie_tovara";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(619, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Naimenovanie_tovara";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.zakaz_zapchasteyBindingSource;
            this.comboBox2.DisplayMember = "Kolichestvo";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(619, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Kolichestvo";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.zakaz_zapchasteyBindingSource;
            this.comboBox3.DisplayMember = "Pokupatel";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(619, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "Pokupatel";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.zakaz_zapchasteyBindingSource;
            this.comboBox4.DisplayMember = "Naimenovanie_zapchastey";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(619, 122);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.ValueMember = "Naimenovanie_zapchastey";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.zakaz_zapchasteyBindingSource;
            this.comboBox5.DisplayMember = "ID_Prodaja_tovara";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(619, 152);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 6;
            this.comboBox5.ValueMember = "ID_Prodaja_tovara";
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.zakaz_zapchasteyBindingSource;
            this.comboBox6.DisplayMember = "ID_Stranyi";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(619, 182);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 24);
            this.comboBox6.TabIndex = 7;
            this.comboBox6.ValueMember = "ID_Stranyi";
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.zakaz_zapchasteyBindingSource;
            this.comboBox7.DisplayMember = "ID_Zapchasti";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(619, 212);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 24);
            this.comboBox7.TabIndex = 8;
            this.comboBox7.ValueMember = "ID_Zapchasti";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Заказзапчастей
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.zakaz_zapchasteyDataGridView);
            this.Controls.Add(this.zakaz_zapchasteyBindingNavigator);
            this.Name = "Заказзапчастей";
            this.Text = "Заказзапчастей";
            this.Load += new System.EventHandler(this.Заказзапчастей_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaz_zapchasteyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaz_zapchasteyBindingNavigator)).EndInit();
            this.zakaz_zapchasteyBindingNavigator.ResumeLayout(false);
            this.zakaz_zapchasteyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakaz_zapchasteyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajatovaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stranaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapchastBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab2_1__1DataSet lab2_1__1DataSet;
        private System.Windows.Forms.BindingSource zakaz_zapchasteyBindingSource;
        private Lab2_1__1DataSetTableAdapters.Zakaz_zapchasteyTableAdapter zakaz_zapchasteyTableAdapter;
        private Lab2_1__1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zakaz_zapchasteyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton zakaz_zapchasteyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView zakaz_zapchasteyDataGridView;
        private Lab2_1__1DataSetTableAdapters.Prodaja_tovaraTableAdapter prodaja_tovaraTableAdapter;
        private System.Windows.Forms.BindingSource prodajatovaraBindingSource;
        private Lab2_1__1DataSetTableAdapters.StranaTableAdapter stranaTableAdapter;
        private System.Windows.Forms.BindingSource stranaBindingSource;
        private Lab2_1__1DataSetTableAdapters.ZapchastTableAdapter zapchastTableAdapter;
        private System.Windows.Forms.BindingSource zapchastBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Prodaja_tovara;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Stranyi;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Zapchasti;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Button button1;
    }
}