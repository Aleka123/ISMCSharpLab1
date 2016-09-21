using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Введіть значення b= ");
            float b = float.Parse(Console.ReadLine());
            float P, S;
            P = 2 * (a + b);
            S = a * b;
            Console.WriteLine("Периметр = ");
            Console.WriteLine(P);
            Console.WriteLine("Площа = ");
            Console.WriteLine(S);
        }
    }
}
