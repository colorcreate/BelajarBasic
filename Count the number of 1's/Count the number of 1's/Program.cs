using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_number_of_1_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai n: ");
            int n = int.Parse(Console.ReadLine());

            
            int number, count = 0;
            for (var i=0; i<n; i++)
            {
                Console.Write("Masukkan angka : ");
                number = int.Parse(Console.ReadLine());
                if (number == 1) count++;
            }

            Console.WriteLine("Anda telah memasukkan angka 1 sebanyak " + count+ " buah");
        }
    }
}
