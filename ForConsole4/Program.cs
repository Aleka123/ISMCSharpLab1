using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення A=");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введіть значення B=");
            int B = int.Parse(Console.ReadLine());
            double c = 0, i;
            for (i = A; i <= B; i++)
                c += Math.Pow(i,2);
            Console.WriteLine("c= ");
            Console.WriteLine(c);
        }
    }
}
