using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введіть значення b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введіть значення x= ");
            double x= double.Parse(Console.ReadLine());
            double y, s, p,r;
            p = Math.Abs((x * x + b) / a);;
            r = Math.Sin(a-b);
            s = Math.Pow(10, -2);
            y =2.4*p+(a-b)*r*r+s*(x-b);
            Console.WriteLine("y = ");
            Console.WriteLine(y);
            
        }
    }
}
