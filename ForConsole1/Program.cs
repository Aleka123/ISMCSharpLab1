using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введіть значення b=");
            int b = int.Parse(Console.ReadLine());
            int c=1, i;
            for (i = a; i <= b; i++)
                c*=i;
            Console.WriteLine("c= ");
            Console.WriteLine(c);
        }
    }
}
