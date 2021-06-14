using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruslan.Форм
{
    public partial class Продажатовара : Form
    {
        public Продажатовара()
        {
            InitializeComponent();
        }

        private void prodaja_tovaraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodaja_tovaraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab2_1__1DataSet);

        }

        private void Продажатовара_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Zakaz_zapchastey". При необходимости она может быть перемещена или удалена.
            this.zakaz_zapchasteyTableAdapter.Fill(this.lab2_1__1DataSet.Zakaz_zapchastey);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.lab2_1__1DataSet.Sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Prodaja_tovara". При необходимости она может быть перемещена или удалена.
            this.prodaja_tovaraTableAdapter.Fill(this.lab2_1__1DataSet.Prodaja_tovara);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 frm2 = new Form1();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }
        private void Frm2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
