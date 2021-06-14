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
    public partial class Заказзапчастей : Form
    {
        public Заказзапчастей()
        {
            InitializeComponent();
        }

        private void zakaz_zapchasteyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zakaz_zapchasteyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab2_1__1DataSet);

        }

        private void Заказзапчастей_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Zapchast". При необходимости она может быть перемещена или удалена.
            this.zapchastTableAdapter.Fill(this.lab2_1__1DataSet.Zapchast);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Strana". При необходимости она может быть перемещена или удалена.
            this.stranaTableAdapter.Fill(this.lab2_1__1DataSet.Strana);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Prodaja_tovara". При необходимости она может быть перемещена или удалена.
            this.prodaja_tovaraTableAdapter.Fill(this.lab2_1__1DataSet.Prodaja_tovara);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Zakaz_zapchastey". При необходимости она может быть перемещена или удалена.
            this.zakaz_zapchasteyTableAdapter.Fill(this.lab2_1__1DataSet.Zakaz_zapchastey);

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
