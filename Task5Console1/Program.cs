using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введіть значення y=");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введіть значення z=");
            double z = double.Parse(Console.ReadLine());
            double  s, r, u, t;
            s = Math.Cos(x-3.141692653/6);     // знаходимо косинус х-пі/6
            r = Math.Abs(x - y);    // знаходимо корінь кубічний з х-1
            u = Math.Sin(y); ;  // знаходимо синус у
            t =(2*s/0.5+u*u )*(1+(z*z/3-z*z/5));
            Console.WriteLine("t =");
            Console.WriteLine(t);
        }
    }
}
