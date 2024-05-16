using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio29
{
    internal class Exercicio29
    {
        static void Main(string[] args)
        {
            int[] vet = new int[6];
            int[] vetPares = new int[6];
            int[] vetImpar = new int[6];
            Random random = new Random();

            int somaPar = 0, qntNumImpar = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = random.Next(1,21);

                if (vet[i] % 2 == 0)
                {
                    // Numeros pares e a soma dos pares.
                    vetPares[i] = vet[i];
                    somaPar += vetPares[i];
                } else
                {
                    // Numeros impares e a soma dos impares
                    vetImpar[i] = vet[i];
                    qntNumImpar++;
                }
            }

            foreach (int p in vetPares)
            {
                if (p != 0)
                {
                    Console.Write(p + " ");
                }
            }

            Console.WriteLine();

            Console.WriteLine($"A soma dos números pares digitados é: {somaPar}");

            Console.WriteLine();

            foreach (int im in vetImpar)
            {
                if (im != 0)
                {
                    Console.Write(im + " ");
                }
            }

            Console.WriteLine();

            Console.WriteLine($"A quantidade de números impares digitados é: {qntNumImpar}");

            Console.ReadLine();
        }
    }
}
