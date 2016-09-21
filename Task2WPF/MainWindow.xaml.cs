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

namespace Task2WPF
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
            double m = double.Parse(textBox.Text);
            double n = double.Parse(textBox1.Text);
            double z1, z2, p, r, s;
            p = Math.Sqrt(m);
            r = Math.Sqrt(n);
            s = Math.Sqrt(m * m * m * n);
            z1 = (((m - n) * p) - (n - 1) * r) / (s + n * m + m * m - m);
            z2 = (p - s) / m;
            textBlock = " " + z1.ToString();
            textBlock1 = " " + z2.ToString();
        }
    }
}
