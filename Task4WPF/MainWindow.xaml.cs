using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task4WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(textBox.Text);
            double y = double.Parse(textBox1.Text);
            double z = double.Parse(textBox2.Text);
            double f, s, p, r, u, t;
            s = Math.Pow(x - 1, 1 / 3);     // знаходимо корінь кубічний з х-1
            p = Math.Pow(y + s, 0.25);    // знаходимо корінь четвертого степеня з (s+y)            r = Math.Abs(x - y);    // знаходимо корінь кубічний з х-1
            u = Math.Sin(z); ;  // знаходимо корінь кубічний з х-1
            r = Math.Abs(x - y);   // знаходимо модуль х-у
            t = Math.Tan(z);    // знаходимо тангенс z
            f = p / r * u * u + t;
            textBlock.Text = "" + f.ToString();
        }
    }
}
