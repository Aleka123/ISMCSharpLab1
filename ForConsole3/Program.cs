﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення A=");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введіть значення N=");
            int N = int.Parse(Console.ReadLine());
            double c = 1.0, i = 1;
            for (i = 1; i <= N; i++)
            {
                c *= Math.Pow(A,i);
            }
            Console.WriteLine("c= ");
            Console.WriteLine(c);
        }
    }
}
