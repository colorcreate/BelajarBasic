﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_with_its_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka :");
            int number = int.Parse(Console.ReadLine());

            Console.Write(number);
            int reverse = 0;
            while(number!=0)
            {
                reverse *= 10;
                reverse += number % 10;
                number /= 10;
            }
            Console.Write(" ==> " + reverse);
        }
    }
}
