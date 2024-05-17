using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] questoes = new int[5, 10];
            int[] gabarito = new int[10];

            Random random = new Random();

            for (int i = 0; i < questoes.GetLength(0); i++)
            {
                for(int j = 0; j < questoes.GetLength(1); j++)
                {
                    questoes[i, j] = random.Next(1, 6);
                    Console.Write(questoes[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for(int i = 0; i <  gabarito.Length;i++)
            {
                gabarito[i] = random.Next(1, 6);
            }

            foreach (int j in gabarito)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();

            int[] resultado = new int[5];
            int acertos = 0;
            for (int i = 0; i < questoes.GetLength(0); i++)
            {
                acertos = 0;
                for (int j = 0; j < questoes.GetLength(1);j++)
                {
                    if (questoes[i,j] == gabarito[j])
                    {
                        acertos++;
                        resultado[i] = acertos;
                    }
                }
            }

            Console.WriteLine();

            foreach (int i in resultado)
            {
                Console.Write($"\nAcertos: {i}");
            }
               
            Console.ReadLine();

        }
    }
}
