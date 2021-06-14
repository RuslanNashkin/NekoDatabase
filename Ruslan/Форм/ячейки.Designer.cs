
namespace Ruslan.Форм
{
    partial class ячейки
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ячейки));
            this.lab2_1__1DataSet = new Ruslan.Lab2_1__1DataSet();
            this.yacheykiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yacheykiTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.YacheykiTableAdapter();
            this.tableAdapterManager = new Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager();
            this.yacheykiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.yacheykiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.yacheykiDataGridView = new System.Windows.Forms.DataGridView();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.SkladTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Sklad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yacheykiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yacheykiBindingNavigator)).BeginInit();
            this.yacheykiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yacheykiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lab2_1__1DataSet
            // 
            this.lab2_1__1DataSet.DataSetName = "Lab2_1__1DataSet";
            this.lab2_1__1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yacheykiBindingSource
            // 
            this.yacheykiBindingSource.DataMember = "Yacheyki";
            this.yacheykiBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // yacheykiTableAdapter
            // 
            this.yacheykiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrakTableAdapter = null;
            this.tableAdapterManager.Kategoria_postavshikaTableAdapter = null;
            this.tableAdapterManager.PostavshikTableAdapter = null;
            this.tableAdapterManager.Prodaja_tovaraTableAdapter = null;
            this.tableAdapterManager.SkidkiTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = this.skladTableAdapter;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vozvrat_brakaTableAdapter = null;
            this.tableAdapterManager.YacheykiTableAdapter = this.yacheykiTableAdapter;
            this.tableAdapterManager.Zakaz_zapchasteyTableAdapter = null;
            this.tableAdapterManager.ZapchastTableAdapter = null;
            // 
            // yacheykiBindingNavigator
            // 
            this.yacheykiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.yacheykiBindingNavigator.BindingSource = this.yacheykiBindingSource;
            this.yacheykiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.yacheykiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.yacheykiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.yacheykiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.yacheykiBindingNavigatorSaveItem});
            this.yacheykiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.yacheykiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.yacheykiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.yacheykiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.yacheykiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.yacheykiBindingNavigator.Name = "yacheykiBindingNavigator";
            this.yacheykiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.yacheykiBindingNavigator.Size = new System.Drawing.Size(686, 27);
            this.yacheykiBindingNavigator.TabIndex = 0;
            this.yacheykiBindingNavigator.Text = "bindingNavigator1";
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
            // yacheykiBindingNavigatorSaveItem
            // 
            this.yacheykiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yacheykiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("yacheykiBindingNavigatorSaveItem.Image")));
            this.yacheykiBindingNavigatorSaveItem.Name = "yacheykiBindingNavigatorSaveItem";
            this.yacheykiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.yacheykiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.yacheykiBindingNavigatorSaveItem.Click += new System.EventHandler(this.yacheykiBindingNavigatorSaveItem_Click);
            // 
            // yacheykiDataGridView
            // 
            this.yacheykiDataGridView.AutoGenerateColumns = false;
            this.yacheykiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yacheykiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ID_Sklad});
            this.yacheykiDataGridView.DataSource = this.yacheykiBindingSource;
            this.yacheykiDataGridView.Location = new System.Drawing.Point(0, 32);
            this.yacheykiDataGridView.Name = "yacheykiDataGridView";
            this.yacheykiDataGridView.RowHeadersWidth = 51;
            this.yacheykiDataGridView.RowTemplate.Height = 24;
            this.yacheykiDataGridView.Size = new System.Drawing.Size(554, 220);
            this.yacheykiDataGridView.TabIndex = 1;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "Sklad";
            this.skladBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Yacheyki";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Yacheyki";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Sklad";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Sklad";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Naimenovanie";
            this.dataGridViewTextBoxColumn3.HeaderText = "Naimenovanie";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Obyom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Obyom";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // ID_Sklad
            // 
            this.ID_Sklad.DataPropertyName = "ID_Sklad";
            this.ID_Sklad.DataSource = this.skladBindingSource;
            this.ID_Sklad.DisplayMember = "Naimenovanie_sklada";
            this.ID_Sklad.HeaderText = "ID_Sklad";
            this.ID_Sklad.MinimumWidth = 6;
            this.ID_Sklad.Name = "ID_Sklad";
            this.ID_Sklad.ValueMember = "ID_Sklad";
            this.ID_Sklad.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.yacheykiBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(560, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Naimenovanie";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.yacheykiBindingSource;
            this.comboBox2.DisplayMember = "Obyom";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(560, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Obyom";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.yacheykiBindingSource;
            this.comboBox3.DisplayMember = "ID_Sklad";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(560, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "ID_Sklad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ячейки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.yacheykiDataGridView);
            this.Controls.Add(this.yacheykiBindingNavigator);
            this.Name = "ячейки";
            this.Text = "ячейки";
            this.Load += new System.EventHandler(this.ячейки_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yacheykiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yacheykiBindingNavigator)).EndInit();
            this.yacheykiBindingNavigator.ResumeLayout(false);
            this.yacheykiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yacheykiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab2_1__1DataSet lab2_1__1DataSet;
        private System.Windows.Forms.BindingSource yacheykiBindingSource;
        private Lab2_1__1DataSetTableAdapters.YacheykiTableAdapter yacheykiTableAdapter;
        private Lab2_1__1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator yacheykiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton yacheykiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView yacheykiDataGridView;
        private Lab2_1__1DataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sklad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
    }
}