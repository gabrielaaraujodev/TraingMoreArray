using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];

            Random random = new Random();

            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 21);
                    Console.Write(matriz[i, j] + "\t");

                    if (i > j)
                    {
                        soma += matriz[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine($"A soma dos valores abaixo da diagonal principal é: {soma}.");

            Console.ReadLine();
        }
    }
}
