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
    public partial class Возвратбрака : Form
    {
        public Возвратбрака()
        {
            InitializeComponent();
        }

        private void vozvrat_brakaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vozvrat_brakaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab2_1__1DataSet);

        }

        private void Возвратбрака_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Brak". При необходимости она может быть перемещена или удалена.
            this.brakTableAdapter.Fill(this.lab2_1__1DataSet.Brak);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Zapchast". При необходимости она может быть перемещена или удалена.
            this.zapchastTableAdapter.Fill(this.lab2_1__1DataSet.Zapchast);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab2_1__1DataSet.Vozvrat_braka". При необходимости она может быть перемещена или удалена.
            this.vozvrat_brakaTableAdapter.Fill(this.lab2_1__1DataSet.Vozvrat_braka);

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
