using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadEquationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть a=");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введiть b=");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Введiть c=");
            float c= float.Parse(Console.ReadLine());
            double d, x1, x2;
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Pow(d, 2)) / 2 * a; ;
                x2 = (-b - Math.Pow(d, 2)) / 2 * a; ;
                Console.Write("x1= ");
                Console.WriteLine(x1);
                Console.Write("x2= ");
                Console.WriteLine(x2);
            }
            else
                if (d == 0)
            {
                x1 = -b / 2 * a;
                Console.Write("x1= ");
                Console.WriteLine(x1);
            }
            else
                Console.WriteLine("не має коренiв, D<0");
        }
    }
}
