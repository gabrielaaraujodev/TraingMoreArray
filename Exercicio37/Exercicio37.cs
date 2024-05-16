using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio37
{
    internal class Exercicio37
    {
        static void Main(string[] args)
        {

            int[] vet = new int[11];

            Random rand = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rand.Next(0, 31);

                for (int j = 0; j < i; j++)
                {
                    if (vet[i] < vet[j])
                    {
                        int switchVar = vet[j];
                        vet[j] = vet[i];
                        vet[i] = switchVar;
                    }
                }
            }

            for (int i = 5; i < vet.Length; i++)
            {
                for (int j = 5; j < i; j++)
                {
                    if (vet[i] > vet[j])
                    {
                        int switchVar = vet[i];
                        vet[i] = vet[j];
                        vet[j] = switchVar;
                    }
                }
            }

            foreach (int i in vet)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();

        }
    }
}
