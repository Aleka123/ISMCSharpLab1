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

namespace ForConsole6
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
            int N = int.Parse(tb1.Text);
            double  i = 1, r=0.0,d=N;
            if (N <= 0)
                Console.WriteLine("N не может быть меньше 0" );
            else
            { for (i = 1; i <= N; i++) 
             {
                    r += Math.Pow(d,i);
                    d--;
                }
            }
            tb2.Text = " " + r.ToString();
        }
    }
}
