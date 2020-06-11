using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract2_ex2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox2.Text);
            n = n % 365 / 30;
            switch (n)
            { 
            case 0: textBox1.Text = Convert.ToString("Январь"); break;
            case 1: textBox1.Text = Convert.ToString("Февраль"); break;
            case 2: textBox1.Text = Convert.ToString("Март"); break;
            case 3: textBox1.Text = Convert.ToString("Апрель"); break;
            case 4: textBox1.Text = Convert.ToString("Май"); break;
            case 5: textBox1.Text = Convert.ToString("Июнь"); break;
            case 6: textBox1.Text = Convert.ToString("Июль"); break;
            case 7: textBox1.Text = Convert.ToString("Август"); break;
            case 8: textBox1.Text = Convert.ToString("Сентябрь"); break;
            case 9: textBox1.Text = Convert.ToString("Октябрь"); break;
            case 10: textBox1.Text = Convert.ToString("Ноябрь"); break;
            case 11: textBox1.Text = Convert.ToString("Декабрь"); break;
            case 12: textBox1.Text = Convert.ToString("Декабрь"); break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
