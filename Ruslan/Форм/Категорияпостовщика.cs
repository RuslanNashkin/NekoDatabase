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
    public partial class Категорияпостовщика : Form
    {
        public Категорияпостовщика()
        {
            InitializeComponent();
        }

        private void kategoria_postavshikaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kategoria_postavshikaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab2_1__1DataSet);

        }

        private void Категорияпостовщика_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Kategoria_postavshika". При необходимости она может быть перемещена или удалена.
            this.kategoria_postavshikaTableAdapter.Fill(this.lab2_1__1DataSet.Kategoria_postavshika);

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
