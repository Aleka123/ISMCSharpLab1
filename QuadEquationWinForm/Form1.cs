using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = float.Parse(textBox3.Text);
            double d, x1, x2;
            d = b * b - 4 * a * c;
            if (d > 0)
            {x1 = (-b + Math.Pow(d, 2)) / 2 * a; ;
                x2 = (-b - Math.Pow(d, 2)) / 2 * a; ;
                textBox4.Text = "" + x1.ToString();
                textBox5.Text = "" + x2.ToString();
            }
            else
                if (d == 0)
            {x1 = -b / 2 * a;
                textBox4.Text = "" + x1.ToString();
            }
            else
                textBox4.Text = "неамає розв‘язків" ;
            label5.Visible = false;
            textBox5.Visible = false;

        }
    }
}

