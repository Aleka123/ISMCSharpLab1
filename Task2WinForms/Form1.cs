using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int m = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            double z1, z2, p, r, s;
            p = System.Math.Sqrt(m);
            r = System.Math.Sqrt(n);
            s = System.Math.Sqrt(m * m * m * n);
            z1 = (((m - n) * p) - (n - 1) * r) / (s + n * m + m * m - m);
            z2 = (p - s) / m;
            textBox3.Text = "" + z1.ToString();
            textBox4.Text = "" + z2.ToString();
        }
    }
}
