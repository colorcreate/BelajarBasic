using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i<n; i++)
            {
                for (int j=0; j<=i; j++)
                {
                    Console.Write((i+j)%2==0 ? 1:0);
                }
                Console.WriteLine();
            }
        }
    }
}
