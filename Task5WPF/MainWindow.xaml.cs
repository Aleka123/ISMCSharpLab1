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

namespace Task5WPF
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
            double s, r, u, t;
            s = Math.Cos(x - 3.14 / 6);     // знаходимо косинус х-пі/6
            r = Math.Abs(x - y);    // знаходимо корінь кубічний з х-1
            u = Math.Sin(y); ;  // знаходимо синус у
            t = (2 * s / 0.5 + u * u) * (1 + (z * z / 3 - z * z / 5));
            textBlock.Text = "" + t.ToString();
        }
    }
}
