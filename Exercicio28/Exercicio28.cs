using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio28
{
    internal class Exercicio28
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];
            int[] v1 = new int[5];
            int[] v2 = new int[5];


            Random random = new Random();

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = random.Next(1,21);

                if (v[i] % 2 == 0)
                {
                    v2[i] = v[i];
                } else
                {
                    v1[i] = v[i];
                }
            }

            foreach (int n in v1)
            {
                if(n != 0)
                {
                    Console.Write($"Os elemenos utilizados em v1 são: {n}");
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");

            foreach (int x in v2)
            {
                if (x != 0)
                {
                    Console.Write($"Os elemenos utilizados em v1 são: {x}");
                    Console.WriteLine("");
                }
            }

            Console.ReadLine();
        }
    }
}
