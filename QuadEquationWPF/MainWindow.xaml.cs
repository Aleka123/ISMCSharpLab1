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

namespace QuadEquationWPF
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
            float a = float.Parse(tb1.Text);
            float b = float.Parse(tb2.Text);
            float c = float.Parse(tb3.Text);
            double d, x1, x2;
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Pow(d, 2)) / 2 * a; ;
                x2 = (-b - Math.Pow(d, 2)) / 2 * a; ;
                tb4.Text = "" + x1.ToString();
                tb5.Text = "" + x2.ToString();
            }
            else
                if (d == 0)
            {
                x1 = -b / 2 * a;
                tb4.Text = "" + x1.ToString();
            }
            else
                tb4.Text = "неамає розв‘язків";
            label4.Visibility = Visibility.Hidden;
            tb5.Visibility = Visibility.Hidden;

        }
    }
}
