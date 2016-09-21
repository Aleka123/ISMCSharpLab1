using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox6.Text);
                int P = 2 * (a + b);
                int S = a * b;
                textBox7.Text = " "+ P.ToString();
                textBox8.Text = " " + S.ToString();
            }
        }
    }
}

