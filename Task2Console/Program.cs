using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення m= ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введіть значення n= ");
            double n = double.Parse(Console.ReadLine());
            double z1, z2,p,r,s;
            p = Math.Sqrt(m);
            r = Math.Sqrt(n);
            s = Math.Sqrt(m*m*m*n);
            z1 =(((m-n)*p)-(n-1)*r)/(s+n*m+m*m-m);
            z2=(p-s)/m;
            Console.WriteLine("z1 = ");
            Console.WriteLine(z1);
            Console.WriteLine("z2 = ");
            Console.WriteLine(z2);
        }
    }
}
