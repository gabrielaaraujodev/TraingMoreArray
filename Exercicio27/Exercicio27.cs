using System;

namespace Exercicio27
{
    internal class Exercicio27
    {

        static void Main(string[] args)
        {
            int[] vet = new int[4];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Informe os numeros para o vetor: ");
                vet[i] = int.Parse(Console.ReadLine());

            }


            for(int i = 0; i < vet.Length; i++)
            {
                bool ePrimo = true;

                for(int j = 2; j < vet[i]; j++)
                {
                    if (vet[i] % j == 0)
                    {
                        ePrimo = false;
                    }
                    
                }
                    if(ePrimo && vet[i] != 1)
                    {
                        Console.WriteLine($"O número {vet[i]} na posição {i} é primo !");
                        Console.WriteLine();
                    }
            }

                Console.ReadLine();
            
        }
    }
}
