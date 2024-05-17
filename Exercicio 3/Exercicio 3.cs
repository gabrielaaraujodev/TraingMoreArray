using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4,4];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = i * j;

                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
