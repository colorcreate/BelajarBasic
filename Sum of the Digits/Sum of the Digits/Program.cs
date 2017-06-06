using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_the_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int r;

            while (number!=0)
            {
                r = number % 10;
                sum += r;
                number = number / 10;
            }

            Console.WriteLine("Jumlah digit-digitnya adalah : "+sum);
        }
    }
}
