using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int x = int.Parse(textBox3.Text);
            double y, s, p, r;
            p = Math.Abs((x * x + b) / a); ;
            r = Math.Sin(a - b);
            s = Math.Pow(10, -2);
            y = 2.4 * p + (a - b) * r * r + s * (x - b);
            textBox4.Text = "" + y.ToString();


        }
    }
}
