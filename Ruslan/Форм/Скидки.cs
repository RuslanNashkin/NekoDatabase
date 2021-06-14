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
    public partial class Скидки : Form
    {
        public Скидки()
        {
            InitializeComponent();
        }

        private void skidkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.skidkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab2_1__1DataSet);

        }

        private void Скидки_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.lab2_1__1DataSet.Postavshik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Skidki". При необходимости она может быть перемещена или удалена.
            this.skidkiTableAdapter.Fill(this.lab2_1__1DataSet.Skidki);

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
