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

namespace Task3WPF
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
            int a = int.Parse(textBox.Text);
            int b = int.Parse(textBox1.Text);
            int x = int.Parse(textBox2.Text);
            double y, s, p, r;
            p = Math.Abs((x * x + b) / a); ;
            r = Math.Sin(a - b);
            s = Math.Pow(10, -2);
            y = 2.4 * p + (a - b) * r * r + s * (x - b);
            textBlock.Text = "" + y.ToString();
        }
    }
}
