
namespace Ruslan.Форм
{
    partial class поставщик
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(поставщик));
            this.lab2_1__1DataSet = new Ruslan.Lab2_1__1DataSet();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.PostavshikTableAdapter();
            this.tableAdapterManager = new Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager();
            this.postavshikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.postavshikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.postavshikDataGridView = new System.Windows.Forms.DataGridView();
            this.vozvratBrakaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vozvrat_brakaTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.Vozvrat_brakaTableAdapter();
            this.zakazzapchasteyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakaz_zapchasteyTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.Zakaz_zapchasteyTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Vozvrat_braka = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Zakaz_zapchastey = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingNavigator)).BeginInit();
            this.postavshikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozvratBrakaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazzapchasteyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lab2_1__1DataSet
            // 
            this.lab2_1__1DataSet.DataSetName = "Lab2_1__1DataSet";
            this.lab2_1__1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrakTableAdapter = null;
            this.tableAdapterManager.Kategoria_postavshikaTableAdapter = null;
            this.tableAdapterManager.PostavshikTableAdapter = this.postavshikTableAdapter;
            this.tableAdapterManager.Prodaja_tovaraTableAdapter = null;
            this.tableAdapterManager.SkidkiTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vozvrat_brakaTableAdapter = this.vozvrat_brakaTableAdapter;
            this.tableAdapterManager.YacheykiTableAdapter = null;
            this.tableAdapterManager.Zakaz_zapchasteyTableAdapter = this.zakaz_zapchasteyTableAdapter;
            this.tableAdapterManager.ZapchastTableAdapter = null;
            // 
            // postavshikBindingNavigator
            // 
            this.postavshikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postavshikBindingNavigator.BindingSource = this.postavshikBindingSource;
            this.postavshikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postavshikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postavshikBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.postavshikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.postavshikBindingNavigatorSaveItem});
            this.postavshikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postavshikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postavshikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postavshikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postavshikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postavshikBindingNavigator.Name = "postavshikBindingNavigator";
            this.postavshikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postavshikBindingNavigator.Size = new System.Drawing.Size(746, 27);
            this.postavshikBindingNavigator.TabIndex = 0;
            this.postavshikBindingNavigator.Text = "bindingNavigator1";
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
            // postavshikBindingNavigatorSaveItem
            // 
            this.postavshikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postavshikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postavshikBindingNavigatorSaveItem.Image")));
            this.postavshikBindingNavigatorSaveItem.Name = "postavshikBindingNavigatorSaveItem";
            this.postavshikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.postavshikBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.postavshikBindingNavigatorSaveItem.Click += new System.EventHandler(this.postavshikBindingNavigatorSaveItem_Click);
            // 
            // postavshikDataGridView
            // 
            this.postavshikDataGridView.AutoGenerateColumns = false;
            this.postavshikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postavshikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ID_Vozvrat_braka,
            this.ID_Zakaz_zapchastey});
            this.postavshikDataGridView.DataSource = this.postavshikBindingSource;
            this.postavshikDataGridView.Location = new System.Drawing.Point(0, 32);
            this.postavshikDataGridView.Name = "postavshikDataGridView";
            this.postavshikDataGridView.RowHeadersWidth = 51;
            this.postavshikDataGridView.RowTemplate.Height = 24;
            this.postavshikDataGridView.Size = new System.Drawing.Size(617, 220);
            this.postavshikDataGridView.TabIndex = 1;
            // 
            // vozvratBrakaBindingSource
            // 
            this.vozvratBrakaBindingSource.DataMember = "Vozvrat braka";
            this.vozvratBrakaBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // vozvrat_brakaTableAdapter
            // 
            this.vozvrat_brakaTableAdapter.ClearBeforeFill = true;
            // 
            // zakazzapchasteyBindingSource
            // 
            this.zakazzapchasteyBindingSource.DataMember = "Zakaz_zapchastey";
            this.zakazzapchasteyBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // zakaz_zapchasteyTableAdapter
            // 
            this.zakaz_zapchasteyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Postavshika";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Postavshika";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naimenovanie_postavshika";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naimenovanie_postavshika";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kategoria_postavshika";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kategoria_postavshika";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Vozvrat_braka";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Vozvrat_braka";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_Zakaz_zapchastey";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_Zakaz_zapchastey";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // ID_Vozvrat_braka
            // 
            this.ID_Vozvrat_braka.DataPropertyName = "ID_Vozvrat_braka";
            this.ID_Vozvrat_braka.DataSource = this.vozvratBrakaBindingSource;
            this.ID_Vozvrat_braka.DisplayMember = "ID_Brak";
            this.ID_Vozvrat_braka.HeaderText = "ID_Vozvrat_braka";
            this.ID_Vozvrat_braka.MinimumWidth = 6;
            this.ID_Vozvrat_braka.Name = "ID_Vozvrat_braka";
            this.ID_Vozvrat_braka.ValueMember = "ID_Vozvrat_braka";
            this.ID_Vozvrat_braka.Width = 125;
            // 
            // ID_Zakaz_zapchastey
            // 
            this.ID_Zakaz_zapchastey.DataPropertyName = "ID_Zakaz_zapchastey";
            this.ID_Zakaz_zapchastey.DataSource = this.zakazzapchasteyBindingSource;
            this.ID_Zakaz_zapchastey.DisplayMember = "Naimenovanie_tovara";
            this.ID_Zakaz_zapchastey.HeaderText = "ID_Zakaz_zapchastey";
            this.ID_Zakaz_zapchastey.MinimumWidth = 6;
            this.ID_Zakaz_zapchastey.Name = "ID_Zakaz_zapchastey";
            this.ID_Zakaz_zapchastey.ValueMember = "ID_Zakaz_zapchastey";
            this.ID_Zakaz_zapchastey.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.postavshikBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie_postavshika";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(623, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Naimenovanie_postavshika";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.postavshikBindingSource;
            this.comboBox2.DisplayMember = "Kategoria_postavshika";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(623, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Kategoria_postavshika";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.postavshikBindingSource;
            this.comboBox3.DisplayMember = "ID_Vozvrat_braka";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(623, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "ID_Vozvrat_braka";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.postavshikBindingSource;
            this.comboBox4.DisplayMember = "ID_Zakaz_zapchastey";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(623, 122);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.ValueMember = "ID_Zakaz_zapchastey";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // поставщик
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.postavshikDataGridView);
            this.Controls.Add(this.postavshikBindingNavigator);
            this.Name = "поставщик";
            this.Text = "поставщик";
            this.Load += new System.EventHandler(this.поставщик_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingNavigator)).EndInit();
            this.postavshikBindingNavigator.ResumeLayout(false);
            this.postavshikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozvratBrakaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazzapchasteyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab2_1__1DataSet lab2_1__1DataSet;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private Lab2_1__1DataSetTableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private Lab2_1__1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postavshikBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton postavshikBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView postavshikDataGridView;
        private Lab2_1__1DataSetTableAdapters.Vozvrat_brakaTableAdapter vozvrat_brakaTableAdapter;
        private System.Windows.Forms.BindingSource vozvratBrakaBindingSource;
        private Lab2_1__1DataSetTableAdapters.Zakaz_zapchasteyTableAdapter zakaz_zapchasteyTableAdapter;
        private System.Windows.Forms.BindingSource zakazzapchasteyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Vozvrat_braka;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Zakaz_zapchastey;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
    }
}