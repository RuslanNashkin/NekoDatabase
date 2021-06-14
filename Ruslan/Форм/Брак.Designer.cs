
namespace Ruslan.Форм
{
    partial class Брак
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Брак));
            this.lab2_1__1DataSet = new Ruslan.Lab2_1__1DataSet();
            this.brakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brakTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.BrakTableAdapter();
            this.tableAdapterManager = new Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager();
            this.brakBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.brakBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.brakDataGridView = new System.Windows.Forms.DataGridView();
            this.zapchastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zapchastTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.ZapchastTableAdapter();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.PostavshikTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Zapchasti = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Postavshika = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brakBindingNavigator)).BeginInit();
            this.brakBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brakDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapchastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lab2_1__1DataSet
            // 
            this.lab2_1__1DataSet.DataSetName = "Lab2_1__1DataSet";
            this.lab2_1__1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brakBindingSource
            // 
            this.brakBindingSource.DataMember = "Brak";
            this.brakBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // brakTableAdapter
            // 
            this.brakTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrakTableAdapter = this.brakTableAdapter;
            this.tableAdapterManager.Kategoria_postavshikaTableAdapter = null;
            this.tableAdapterManager.PostavshikTableAdapter = this.postavshikTableAdapter;
            this.tableAdapterManager.Prodaja_tovaraTableAdapter = null;
            this.tableAdapterManager.SkidkiTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vozvrat_brakaTableAdapter = null;
            this.tableAdapterManager.YacheykiTableAdapter = null;
            this.tableAdapterManager.Zakaz_zapchasteyTableAdapter = null;
            this.tableAdapterManager.ZapchastTableAdapter = this.zapchastTableAdapter;
            // 
            // brakBindingNavigator
            // 
            this.brakBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.brakBindingNavigator.BindingSource = this.brakBindingSource;
            this.brakBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.brakBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.brakBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.brakBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.brakBindingNavigatorSaveItem});
            this.brakBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.brakBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.brakBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.brakBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.brakBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.brakBindingNavigator.Name = "brakBindingNavigator";
            this.brakBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.brakBindingNavigator.Size = new System.Drawing.Size(683, 27);
            this.brakBindingNavigator.TabIndex = 0;
            this.brakBindingNavigator.Text = "bindingNavigator1";
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
            // brakBindingNavigatorSaveItem
            // 
            this.brakBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brakBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("brakBindingNavigatorSaveItem.Image")));
            this.brakBindingNavigatorSaveItem.Name = "brakBindingNavigatorSaveItem";
            this.brakBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.brakBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.brakBindingNavigatorSaveItem.Click += new System.EventHandler(this.brakBindingNavigatorSaveItem_Click);
            // 
            // brakDataGridView
            // 
            this.brakDataGridView.AutoGenerateColumns = false;
            this.brakDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brakDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ID_Zapchasti,
            this.ID_Postavshika});
            this.brakDataGridView.DataSource = this.brakBindingSource;
            this.brakDataGridView.Location = new System.Drawing.Point(0, 32);
            this.brakDataGridView.Name = "brakDataGridView";
            this.brakDataGridView.RowHeadersWidth = 51;
            this.brakDataGridView.RowTemplate.Height = 24;
            this.brakDataGridView.Size = new System.Drawing.Size(554, 220);
            this.brakDataGridView.TabIndex = 1;
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
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Brak";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Brak";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Zapchasti";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Zapchasti";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Postavshika";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Postavshika";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Naimenovanie";
            this.dataGridViewTextBoxColumn4.HeaderText = "Naimenovanie";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
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
            // ID_Postavshika
            // 
            this.ID_Postavshika.DataPropertyName = "ID_Postavshika";
            this.ID_Postavshika.DataSource = this.postavshikBindingSource;
            this.ID_Postavshika.DisplayMember = "Naimenovanie_postavshika";
            this.ID_Postavshika.HeaderText = "ID_Postavshika";
            this.ID_Postavshika.MinimumWidth = 6;
            this.ID_Postavshika.Name = "ID_Postavshika";
            this.ID_Postavshika.ValueMember = "ID_Postavshika";
            this.ID_Postavshika.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.brakBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(560, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Naimenovanie";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.brakBindingSource;
            this.comboBox2.DisplayMember = "ID_Zapchasti";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(560, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "ID_Zapchasti";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.brakBindingSource;
            this.comboBox3.DisplayMember = "ID_Postavshika";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(560, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "ID_Postavshika";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Брак
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.brakDataGridView);
            this.Controls.Add(this.brakBindingNavigator);
            this.Name = "Брак";
            this.Text = "Брак";
            this.Load += new System.EventHandler(this.Брак_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brakBindingNavigator)).EndInit();
            this.brakBindingNavigator.ResumeLayout(false);
            this.brakBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brakDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapchastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab2_1__1DataSet lab2_1__1DataSet;
        private System.Windows.Forms.BindingSource brakBindingSource;
        private Lab2_1__1DataSetTableAdapters.BrakTableAdapter brakTableAdapter;
        private Lab2_1__1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator brakBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton brakBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView brakDataGridView;
        private Lab2_1__1DataSetTableAdapters.ZapchastTableAdapter zapchastTableAdapter;
        private System.Windows.Forms.BindingSource zapchastBindingSource;
        private Lab2_1__1DataSetTableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Zapchasti;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Postavshika;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
    }
}