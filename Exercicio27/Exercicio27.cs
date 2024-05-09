using System;

namespace Exercicio27
{
    internal class Exercicio27
    {

        static void Main(string[] args)
        {
            int[] vet = new int[2];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Informe os numeros para o vetor: ");
                vet[i] = int.Parse(Console.ReadLine());

            }


                Console.ReadLine();
            
        }
    }
}
