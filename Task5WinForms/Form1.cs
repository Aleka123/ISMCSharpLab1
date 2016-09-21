using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5WinForms
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
            double s, r, u, t;
            s = Math.Cos(x - 3.14 / 6);     // знаходимо косинус х-пі/6
            r = Math.Abs(x - y);    // знаходимо корінь кубічний з х-1
            u = Math.Sin(y); ;  // знаходимо синус у
            t = (2 * s / 0.5 + u * u) * (1 + (z * z / 3 - z * z / 5));
            textBox4.Text = "" + t.ToString();
        }
    }
}
