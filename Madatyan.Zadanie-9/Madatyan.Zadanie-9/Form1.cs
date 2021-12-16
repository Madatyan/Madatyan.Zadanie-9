using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
               int s = (a * b);
                textBox3.Text = Convert.ToString(s);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int s = (a * b);
                textBox3.Text = Convert.ToString(s);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                int s = (a * b);
                textBox3.Text = Convert.ToString(s);
            }
        }
    }
}
