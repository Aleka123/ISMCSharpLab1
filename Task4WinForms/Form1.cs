using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int z = int.Parse(textBox3.Text);
            double f, s, p, r, u, t;
            s = Math.Pow(x - 1, 1 / 3);     // знаходимо корінь кубічний з х-1
            p = Math.Pow(y + s, 0.25);    // знаходимо корінь четвертого степеня з (s+y)            r = Math.Abs(x - y);    // знаходимо корінь кубічний з х-1
            u = Math.Sin(z); ;  // знаходимо корінь кубічний з х-1
            r = Math.Abs(x - y);   // знаходимо модуль х-у
            t = Math.Tan(z);    // знаходимо тангенс z
            f = p / r * u * u + t;
            textBox4.Text = "" + f.ToString();
        }
    }
}
