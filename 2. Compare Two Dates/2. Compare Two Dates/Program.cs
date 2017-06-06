using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Compare_Two_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2017, 06, 06);
            Console.WriteLine("Starting date\t: {0}", date1);
            DateTime date2 = date1.AddDays(10);
            Console.WriteLine("Ending date\t: {0}", date2);

            Console.WriteLine("{0} terjadi sebelum {1}", date1, date2);

        }
    }
}
