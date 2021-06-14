
namespace Ruslan.Форм
{
    partial class Продажатовара
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Продажатовара));
            this.lab2_1__1DataSet = new Ruslan.Lab2_1__1DataSet();
            this.prodaja_tovaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodaja_tovaraTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.Prodaja_tovaraTableAdapter();
            this.tableAdapterManager = new Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager();
            this.prodaja_tovaraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prodaja_tovaraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prodaja_tovaraDataGridView = new System.Windows.Forms.DataGridView();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.SkladTableAdapter();
            this.zakazzapchasteyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakaz_zapchasteyTableAdapter = new Ruslan.Lab2_1__1DataSetTableAdapters.Zakaz_zapchasteyTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Sklad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Zakaz_zapchastey = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaja_tovaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaja_tovaraBindingNavigator)).BeginInit();
            this.prodaja_tovaraBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodaja_tovaraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazzapchasteyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lab2_1__1DataSet
            // 
            this.lab2_1__1DataSet.DataSetName = "Lab2_1__1DataSet";
            this.lab2_1__1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodaja_tovaraBindingSource
            // 
            this.prodaja_tovaraBindingSource.DataMember = "Prodaja_tovara";
            this.prodaja_tovaraBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // prodaja_tovaraTableAdapter
            // 
            this.prodaja_tovaraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrakTableAdapter = null;
            this.tableAdapterManager.Kategoria_postavshikaTableAdapter = null;
            this.tableAdapterManager.PostavshikTableAdapter = null;
            this.tableAdapterManager.Prodaja_tovaraTableAdapter = this.prodaja_tovaraTableAdapter;
            this.tableAdapterManager.SkidkiTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = this.skladTableAdapter;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ruslan.Lab2_1__1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vozvrat_brakaTableAdapter = null;
            this.tableAdapterManager.YacheykiTableAdapter = null;
            this.tableAdapterManager.Zakaz_zapchasteyTableAdapter = this.zakaz_zapchasteyTableAdapter;
            this.tableAdapterManager.ZapchastTableAdapter = null;
            // 
            // prodaja_tovaraBindingNavigator
            // 
            this.prodaja_tovaraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prodaja_tovaraBindingNavigator.BindingSource = this.prodaja_tovaraBindingSource;
            this.prodaja_tovaraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prodaja_tovaraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prodaja_tovaraBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.prodaja_tovaraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prodaja_tovaraBindingNavigatorSaveItem});
            this.prodaja_tovaraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prodaja_tovaraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prodaja_tovaraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prodaja_tovaraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prodaja_tovaraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prodaja_tovaraBindingNavigator.Name = "prodaja_tovaraBindingNavigator";
            this.prodaja_tovaraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prodaja_tovaraBindingNavigator.Size = new System.Drawing.Size(705, 27);
            this.prodaja_tovaraBindingNavigator.TabIndex = 0;
            this.prodaja_tovaraBindingNavigator.Text = "bindingNavigator1";
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
            // prodaja_tovaraBindingNavigatorSaveItem
            // 
            this.prodaja_tovaraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prodaja_tovaraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prodaja_tovaraBindingNavigatorSaveItem.Image")));
            this.prodaja_tovaraBindingNavigatorSaveItem.Name = "prodaja_tovaraBindingNavigatorSaveItem";
            this.prodaja_tovaraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.prodaja_tovaraBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.prodaja_tovaraBindingNavigatorSaveItem.Click += new System.EventHandler(this.prodaja_tovaraBindingNavigatorSaveItem_Click);
            // 
            // prodaja_tovaraDataGridView
            // 
            this.prodaja_tovaraDataGridView.AutoGenerateColumns = false;
            this.prodaja_tovaraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodaja_tovaraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.ID_Sklad,
            this.ID_Zakaz_zapchastey});
            this.prodaja_tovaraDataGridView.DataSource = this.prodaja_tovaraBindingSource;
            this.prodaja_tovaraDataGridView.Location = new System.Drawing.Point(0, 32);
            this.prodaja_tovaraDataGridView.Name = "prodaja_tovaraDataGridView";
            this.prodaja_tovaraDataGridView.RowHeadersWidth = 51;
            this.prodaja_tovaraDataGridView.RowTemplate.Height = 24;
            this.prodaja_tovaraDataGridView.Size = new System.Drawing.Size(574, 220);
            this.prodaja_tovaraDataGridView.TabIndex = 1;
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
            // zakazzapchasteyBindingSource
            // 
            this.zakazzapchasteyBindingSource.DataMember = "Zakaz_zapchastey";
            this.zakazzapchasteyBindingSource.DataSource = this.lab2_1__1DataSet;
            // 
            // zakaz_zapchasteyTableAdapter
            // 
            this.zakaz_zapchasteyTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.prodaja_tovaraBindingSource;
            this.comboBox1.DisplayMember = "Edinitsi_tovara";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(580, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Edinitsi_tovara";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.prodaja_tovaraBindingSource;
            this.comboBox2.DisplayMember = "Summa";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(580, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Summa";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.prodaja_tovaraBindingSource;
            this.comboBox3.DisplayMember = "Rashodi";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(580, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "Rashodi";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.prodaja_tovaraBindingSource;
            this.comboBox4.DisplayMember = "ID_Sklad";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(580, 122);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.ValueMember = "ID_Sklad";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.prodaja_tovaraBindingSource;
            this.comboBox5.DisplayMember = "ID_Zakaz_zapchastey";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(580, 152);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 6;
            this.comboBox5.ValueMember = "ID_Zakaz_zapchastey";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Prodaja_tovara";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Prodaja_tovara";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Edinitsi_tovara";
            this.dataGridViewTextBoxColumn2.HeaderText = "Edinitsi_tovara";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Summa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Summa";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Tovara";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Tovara";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_Sklad";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_Sklad";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
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
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Rashodi";
            this.dataGridViewTextBoxColumn7.HeaderText = "Rashodi";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
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
            // ID_Zakaz_zapchastey
            // 
            this.ID_Zakaz_zapchastey.DataPropertyName = "ID_Zakaz_zapchastey";
            this.ID_Zakaz_zapchastey.DataSource = this.zakazzapchasteyBindingSource;
            this.ID_Zakaz_zapchastey.DisplayMember = "Naimenovanie_zapchastey";
            this.ID_Zakaz_zapchastey.HeaderText = "ID_Zakaz_zapchastey";
            this.ID_Zakaz_zapchastey.MinimumWidth = 6;
            this.ID_Zakaz_zapchastey.Name = "ID_Zakaz_zapchastey";
            this.ID_Zakaz_zapchastey.ValueMember = "ID_Zakaz_zapchastey";
            this.ID_Zakaz_zapchastey.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Продажатовара
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.prodaja_tovaraDataGridView);
            this.Controls.Add(this.prodaja_tovaraBindingNavigator);
            this.Name = "Продажатовара";
            this.Text = "Продажатовара";
            this.Load += new System.EventHandler(this.Продажатовара_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab2_1__1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaja_tovaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaja_tovaraBindingNavigator)).EndInit();
            this.prodaja_tovaraBindingNavigator.ResumeLayout(false);
            this.prodaja_tovaraBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodaja_tovaraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazzapchasteyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab2_1__1DataSet lab2_1__1DataSet;
        private System.Windows.Forms.BindingSource prodaja_tovaraBindingSource;
        private Lab2_1__1DataSetTableAdapters.Prodaja_tovaraTableAdapter prodaja_tovaraTableAdapter;
        private Lab2_1__1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prodaja_tovaraBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prodaja_tovaraBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView prodaja_tovaraDataGridView;
        private Lab2_1__1DataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private Lab2_1__1DataSetTableAdapters.Zakaz_zapchasteyTableAdapter zakaz_zapchasteyTableAdapter;
        private System.Windows.Forms.BindingSource zakazzapchasteyBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sklad;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Zakaz_zapchastey;
        private System.Windows.Forms.Button button1;
    }
}