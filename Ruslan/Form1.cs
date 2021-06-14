using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruslan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Форм.запчасти frm2 = new Форм.запчасти();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }
        private void Frm2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Форм.Брак frm2 = new Форм.Брак();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            Форм.Категорияпостовщика frm2 = new Форм.Категорияпостовщика();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Форм.поставщик frm2 = new Форм.поставщик();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Форм.Продажатовара frm2 = new Форм.Продажатовара();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Форм.Скидки frm2 = new Форм.Скидки();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Форм.Склад frm2 = new Форм.Склад();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            Форм.Страна frm2 = new Форм.Страна();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Форм.Возвратбрака frm2 = new Форм.Возвратбрака();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Форм.ячейки frm2 = new Форм.ячейки();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Форм.Заказзапчастей frm2 = new Форм.Заказзапчастей();
            frm2.FormClosed += Frm2_FormClosed;
            frm2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
