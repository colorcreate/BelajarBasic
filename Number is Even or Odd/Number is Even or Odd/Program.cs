using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_is_Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Masukkan angka : ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("\n"+ number + " adalah bilangan genap");
            else
                Console.WriteLine("\n"+ number + " adalah bilangan ganjil"); 
        }
    }
}
