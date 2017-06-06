using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan tahun yang akan dicek: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} adalah tahun kabisat", year);
            }
            else
            {
                Console.WriteLine("{0} adalah bukan tahun kabisat", year);
            }
        }
    }
}
