using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio36
{
    internal class Exercicio36
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];

            Random rand = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rand.Next(0,11);

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

            foreach (int i in vet)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
