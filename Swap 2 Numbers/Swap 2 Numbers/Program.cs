using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_2_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan bilangan pertama\t: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilangan kedua\t\t: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write(n1+", "+n2+" ==> ");
            int temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine(n1+", "+n2);
        }
    }
}
