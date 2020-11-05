using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se citeste un vector cu n elemente, numere naturale. 
            //Sa se afiseze elementele din vector care sunt multiplii ai ultimului element.

            Console.Write("Introduceti numarul elementelor din vector : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} elemente in vector :");
            int[] v = new int[n];

            for(int i=0;i<n;i++)            
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Elemente multiplii al ultimului element : ");
            for (int i = 0; i < n; i++)                
                if (v[i] % v[n - 1] == 0)
                    Console.WriteLine(v[i]);               

            Console.ReadKey();
        }
    }
}
