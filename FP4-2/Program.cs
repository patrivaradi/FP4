using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se determine maximul şi minimul valorilor elementelor unui vector.
            Console.Write("Introduceti numarul elementelor din vector : ");
            int n = int.Parse(Console.ReadLine());
            int min, max = 0;
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
            Console.WriteLine("Minimul "+min);
            Console.WriteLine("Maximul "+max);
            Console.ReadKey();

        }
    }
}
