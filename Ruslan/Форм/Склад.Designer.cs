
namespace Ruslan.Форм
{
    partial class Склад
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Склад));
            this.lab2_1__1DataSet = new Ruslan.Lab2_1__1DataSet();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.SkladTableAdapter();
            this.tableAdapterManager = new Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager();
            this.skladBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.skladBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.skladDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingNavigator)).BeginInit();
            this.skladBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lab2_1__1DataSet
            // 
            this.lab2_1__1DataSet.DataSetName = "Lab2_1__1DataSet";
            this.lab2_1__1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.YacheykiTableAdapter = null;
            this.tableAdapterManager.Zakaz_zapchasteyTableAdapter = null;
            this.tableAdapterManager.ZapchastTableAdapter = null;
            // 
            // skladBindingNavigator
            // 
            this.skladBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.skladBindingNavigator.BindingSource = this.skladBindingSource;
            this.skladBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.skladBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.skladBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.skladBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.skladBindingNavigatorSaveItem});
            this.skladBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.skladBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.skladBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.skladBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.skladBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.skladBindingNavigator.Name = "skladBindingNavigator";
            this.skladBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.skladBindingNavigator.Size = new System.Drawing.Size(558, 27);
            this.skladBindingNavigator.TabIndex = 0;
            this.skladBindingNavigator.Text = "bindingNavigator1";
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
            // skladBindingNavigatorSaveItem
            // 
            this.skladBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.skladBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("skladBindingNavigatorSaveItem.Image")));
            this.skladBindingNavigatorSaveItem.Name = "skladBindingNavigatorSaveItem";
            this.skladBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.skladBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.skladBindingNavigatorSaveItem.Click += new System.EventHandler(this.skladBindingNavigatorSaveItem_Click);
            // 
            // skladDataGridView
            // 
            this.skladDataGridView.AutoGenerateColumns = false;
            this.skladDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skladDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.skladDataGridView.DataSource = this.skladBindingSource;
            this.skladDataGridView.Location = new System.Drawing.Point(0, 32);
            this.skladDataGridView.Name = "skladDataGridView";
            this.skladDataGridView.RowHeadersWidth = 51;
            this.skladDataGridView.RowTemplate.Height = 24;
            this.skladDataGridView.Size = new System.Drawing.Size(431, 220);
            this.skladDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Sklad";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Sklad";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Adres";
            this.dataGridViewTextBoxColumn2.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Naimenovanie_sklada";
            this.dataGridViewTextBoxColumn3.HeaderText = "Naimenovanie_sklada";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.skladBindingSource;
            this.comboBox1.DisplayMember = "Adres";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(437, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Adres";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.skladBindingSource;
            this.comboBox2.DisplayMember = "Naimenovanie_sklada";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(437, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Naimenovanie_sklada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Склад
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.skladDataGridView);
            this.Controls.Add(this.skladBindingNavigator);
            this.Name = "Склад";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.Склад_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingNavigator)).EndInit();
            this.skladBindingNavigator.ResumeLayout(false);
            this.skladBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab2_1__1DataSet lab2_1__1DataSet;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private Lab2_1__1DataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private Lab2_1__1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator skladBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton skladBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView skladDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}