using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dă un vector cu n numere naturale. 
            //Să se determine câte dintre elemente au valoarea strict mai mare decât media aritmetică a elementelor vectorului.
            Console.Write("Introduceti numarul elementelor din vector : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} elemente in vector :");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int ma=0;
            for (int i = 0; i < n; i++)
            {
                ma += v[i];
            }
            int media = ma / n;
            Console.WriteLine($"Media aritmetica a elementelor vectorului este : {media}");
            int elemente = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i]>media)
                {
                    elemente++;
                }
            }
            Console.WriteLine($"{elemente} elemente au valoarea strict mai mare decat media aritmetica a vectorului.");
            Console.ReadKey();
        }
    }
}
