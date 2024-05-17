using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1___Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int cont = 0;

            Random rand = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(1, 21);
                    if (matriz[i, j] > 10)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine($"A matriz possui {cont} valores maiores que 10 !");
            Console.ReadLine();
        }
    }
}
