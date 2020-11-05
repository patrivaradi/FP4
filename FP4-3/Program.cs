using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Se citește un vector cu n elemente, numere naturale. 
            ///Să se determine câte elemente ale vectorului sunt egale cu diferența 
            ///dintre cea mai mare și cea mai mică valoare din vector.
            Console.Write("Introduceti numarul elementelor din vector : ");
            int n = int.Parse(Console.ReadLine());
            int min, max;            
            Console.WriteLine($"Introduceti {n} elemente in vector :");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            min = max = v[0];
            for (int i = 0; i < n; i++)
            {
                if (v[i] < min)
                    min = v[i];
                if (v[i] > max)
                    max = v[i];
            }
            int d;
            int s = 0;
            d = max - min;            
            for (int i = 0; i < n; i++)
            {
                if (v[i] == d)                
                    s += 1;                
            }
            Console.WriteLine($"Sunt {s} elemente care sunt egale cu minimul - maximul din vector.");
            Console.ReadKey();
        }
    }
}
