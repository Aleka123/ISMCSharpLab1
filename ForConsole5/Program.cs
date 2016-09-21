using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення N=");
            int N = int.Parse(Console.ReadLine());
            double i, f = 1, s = 1,d=0;
            for (i = 1; i <= N; i++)
            {
                  f = 1;
                for (s = 1; s <= i; s++)
                    f *= s;
                        d += f;
                
                Console.WriteLine("d= ");
                Console.WriteLine(d);
            }
        }
    }
}
