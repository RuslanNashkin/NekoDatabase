
namespace Ruslan.Форм
{
    partial class Возвратбрака
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Возвратбрака));
            this.lab2_1__1DataSet = new Ruslan.Lab2_1__1DataSet();
            this.vozvrat_brakaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vozvrat_brakaTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.Vozvrat_brakaTableAdapter();
            this.tableAdapterManager = new Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager();
            this.vozvrat_brakaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vozvrat_brakaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vozvrat_brakaDataGridView = new System.Windows.Forms.DataGridView();
            this.zapchastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zapchastTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.ZapchastTableAdapter();
            this.brakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brakTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.BrakTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Zapchasti = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Brak = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozvrat_brakaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozvrat_brakaBindingNavigator)).BeginInit();
            this.vozvrat_brakaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vozvrat_brakaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapchastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lab2_1__1DataSet
            // 
            this.lab2_1__1DataSet.DataSetName = "Lab2_1__1DataSet";
            this.lab2_1__1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vozvrat_brakaBindingSource
            // 
            this.vozvrat_brakaBindingSource.DataMember = "Vozvrat braka";
            this.vozvrat_brakaBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // vozvrat_brakaTableAdapter
            // 
            this.vozvrat_brakaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrakTableAdapter = this.brakTableAdapter;
            this.tableAdapterManager.Kategoria_postavshikaTableAdapter = null;
            this.tableAdapterManager.PostavshikTableAdapter = null;
            this.tableAdapterManager.Prodaja_tovaraTableAdapter = null;
            this.tableAdapterManager.SkidkiTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vozvrat_brakaTableAdapter = this.vozvrat_brakaTableAdapter;
            this.tableAdapterManager.YacheykiTableAdapter = null;
            this.tableAdapterManager.Zakaz_zapchasteyTableAdapter = null;
            this.tableAdapterManager.ZapchastTableAdapter = this.zapchastTableAdapter;
            // 
            // vozvrat_brakaBindingNavigator
            // 
            this.vozvrat_brakaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vozvrat_brakaBindingNavigator.BindingSource = this.vozvrat_brakaBindingSource;
            this.vozvrat_brakaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vozvrat_brakaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vozvrat_brakaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vozvrat_brakaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vozvrat_brakaBindingNavigatorSaveItem});
            this.vozvrat_brakaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vozvrat_brakaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vozvrat_brakaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vozvrat_brakaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vozvrat_brakaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vozvrat_brakaBindingNavigator.Name = "vozvrat_brakaBindingNavigator";
            this.vozvrat_brakaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vozvrat_brakaBindingNavigator.Size = new System.Drawing.Size(564, 27);
            this.vozvrat_brakaBindingNavigator.TabIndex = 0;
            this.vozvrat_brakaBindingNavigator.Text = "bindingNavigator1";
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
            // vozvrat_brakaBindingNavigatorSaveItem
            // 
            this.vozvrat_brakaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vozvrat_brakaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vozvrat_brakaBindingNavigatorSaveItem.Image")));
            this.vozvrat_brakaBindingNavigatorSaveItem.Name = "vozvrat_brakaBindingNavigatorSaveItem";
            this.vozvrat_brakaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.vozvrat_brakaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.vozvrat_brakaBindingNavigatorSaveItem.Click += new System.EventHandler(this.vozvrat_brakaBindingNavigatorSaveItem_Click);
            // 
            // vozvrat_brakaDataGridView
            // 
            this.vozvrat_brakaDataGridView.AutoGenerateColumns = false;
            this.vozvrat_brakaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vozvrat_brakaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ID_Zapchasti,
            this.ID_Brak});
            this.vozvrat_brakaDataGridView.DataSource = this.vozvrat_brakaBindingSource;
            this.vozvrat_brakaDataGridView.Location = new System.Drawing.Point(0, 32);
            this.vozvrat_brakaDataGridView.Name = "vozvrat_brakaDataGridView";
            this.vozvrat_brakaDataGridView.RowHeadersWidth = 51;
            this.vozvrat_brakaDataGridView.RowTemplate.Height = 24;
            this.vozvrat_brakaDataGridView.Size = new System.Drawing.Size(431, 220);
            this.vozvrat_brakaDataGridView.TabIndex = 1;
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
            // brakBindingSource
            // 
            this.brakBindingSource.DataMember = "Brak";
            this.brakBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // brakTableAdapter
            // 
            this.brakTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Vozvrat_braka";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Vozvrat_braka";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Brak";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Brak";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
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
            // ID_Brak
            // 
            this.ID_Brak.DataPropertyName = "ID_Brak";
            this.ID_Brak.DataSource = this.brakBindingSource;
            this.ID_Brak.DisplayMember = "Naimenovanie";
            this.ID_Brak.HeaderText = "ID_Brak";
            this.ID_Brak.MinimumWidth = 6;
            this.ID_Brak.Name = "ID_Brak";
            this.ID_Brak.ValueMember = "ID_Brak";
            this.ID_Brak.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vozvrat_brakaBindingSource;
            this.comboBox1.DisplayMember = "ID_Zapchasti";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(437, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID_Zapchasti";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.vozvrat_brakaBindingSource;
            this.comboBox2.DisplayMember = "ID_Brak";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(437, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "ID_Brak";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Возвратбрака
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.vozvrat_brakaDataGridView);
            this.Controls.Add(this.vozvrat_brakaBindingNavigator);
            this.Name = "Возвратбрака";
            this.Text = "Возвратбрака";
            this.Load += new System.EventHandler(this.Возвратбрака_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozvrat_brakaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozvrat_brakaBindingNavigator)).EndInit();
            this.vozvrat_brakaBindingNavigator.ResumeLayout(false);
            this.vozvrat_brakaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vozvrat_brakaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapchastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab2_1__1DataSet lab2_1__1DataSet;
        private System.Windows.Forms.BindingSource vozvrat_brakaBindingSource;
        private Lab2_1__1DataSetTableAdapters.Vozvrat_brakaTableAdapter vozvrat_brakaTableAdapter;
        private Lab2_1__1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vozvrat_brakaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vozvrat_brakaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vozvrat_brakaDataGridView;
        private Lab2_1__1DataSetTableAdapters.ZapchastTableAdapter zapchastTableAdapter;
        private System.Windows.Forms.BindingSource zapchastBindingSource;
        private Lab2_1__1DataSetTableAdapters.BrakTableAdapter brakTableAdapter;
        private System.Windows.Forms.BindingSource brakBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Zapchasti;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Brak;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}