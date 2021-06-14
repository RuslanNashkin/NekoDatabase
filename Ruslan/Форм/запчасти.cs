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
    public partial class запчасти : Form
    {
        public запчасти()
        {
            InitializeComponent();
        }

        private void zapchastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zapchastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab2_1__1DataSet);

        }

        private void запчасти_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Zapchast". При необходимости она может быть перемещена или удалена.
            this.zapchastTableAdapter.Fill(this.lab2_1__1DataSet.Zapchast);

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
