using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Console
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
            double f, s, p, r,u,t;
            s = Math.Pow(x-1, 1/3);     // знаходимо корінь кубічний з х-1
            p = Math.Pow(y+s, 0.25);    // знаходимо корінь четвертого степеня з (s+y)            r = Math.Abs(x - y);    // знаходимо корінь кубічний з х-1
            u = Math.Sin(z); ;  // знаходимо корінь кубічний з х-1
            r =Math.Abs(x-y);   // знаходимо модуль х-у
            t = Math.Tan(z);    // знаходимо тангенс z
            f =p/r*u*u+t;   
            Console.WriteLine("f =");
            Console.WriteLine(f);
        }
    }
}
