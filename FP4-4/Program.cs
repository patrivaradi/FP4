using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se citeste un vector cu n elemente, numere naturale. 
            //Sa se afiseze inversul vectorului introdus.
            Console.Write("Introduceti numarul elementelor din vector : ");
            int n = int.Parse(Console.ReadLine());
            int min, max = 0;
            Console.WriteLine($"Introduceti {n} elemente in vector :");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Inversul vectorului este : ");
            for (int i = n - 1; i >= 0; i--)
                Console.Write(v[i] + " ");
            Console.ReadKey();

        }
    }
}
