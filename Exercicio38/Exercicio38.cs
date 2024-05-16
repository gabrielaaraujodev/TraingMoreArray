using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio38
{
    internal class Exercicio38
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Informe o {i + 1}º valor: ");
                vet[i] = int.Parse(Console.ReadLine());

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

            foreach(int i in vet)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
