using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio33
{
    internal class Exercicio33
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int[] vet = new int[15];
            Random rand = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rand.Next(0, 51);

                if (vet[i] != 0)
                {
                    vet[cont] = vet[i];
                    cont++;
                }
            }

          foreach (int i in vet)
            {
                if (vet[i] != 0)
                {
                    Console.Write(i + " ");
                }
                
            }

            Console.ReadLine();
        }
    }
}
