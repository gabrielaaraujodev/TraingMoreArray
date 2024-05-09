using System;

namespace Exercicio26
{
    internal class Exercicio26
    {
        static void Main(string[] args)
        {
            int n = 10;
            double[] vet = new double[n];
            double soma = 0;
            Random random = new Random();
 
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = random.Next(1,11);
                soma += vet[i];
            }

            double media = soma / vet.Length;


            double somaDesvio = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                somaDesvio += Math.Pow((vet[i] - media), 2);
            }


            double desvioPadrao = Math.Sqrt((1 * somaDesvio) / (n - 1));
            int desvioPadraoAjustado = (int)desvioPadrao; // Caso queira receber só a parte inteira.

            Console.WriteLine(desvioPadrao);


            Console.ReadLine();
        }
    }
}
