﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Progra123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //obtener la secuencia fibonacii
            int a = 0, b = 1, c = 1;
            /*
             0+1=1
            */
            while (c < 100)
            {
                Console.WriteLine("{0}+{1}={2}", a, b, c);
                b = a;
                a = c;
                c = a + b;
            }
            Console.ReadLine();
        }
    }
}