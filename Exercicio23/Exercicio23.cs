using System;

namespace Exercicio23
{
    internal class Exercicio23
    {
        static void Main(string[] args)
        {
            double[] vetA = new double[5];
            double[] vetB = new double[5];

            double[] produto = new double[5];

            double soma = 0;

            Random rand = new Random();

            for(int i  = 0; i < vetA.Length; i++)
            {
                vetA[i] = rand.Next(1,21);
                vetB[i] = rand.Next(1,21);
            }

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.Write(vetA[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.Write(vetB[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < vetA.Length; i++)
            {
                produto[i] = vetA[i] * vetB[i];
                soma += produto[i];
            }

            Console.WriteLine();

            for (int i = 0; i < produto.Length; i++)
            {
                Console.Write(produto[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("A soma do produto escalar é: " + soma);

            Console.ReadLine();
        }
    }
}
