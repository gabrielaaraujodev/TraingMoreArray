using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matA = new int[3, 3];
            int[,] matB = new int[3, 3];
            Random random = new Random();

            for(int i = 0; i < matA.GetLength(0); i++)
            {
                for(int j = 0; j < matA.GetLength(1); j++)
                {
                    matA[i,j] = random.Next(1,11);
                    matB[i,j] = random.Next(1,11);
                }
            }

            int[,] matC = new int[3, 3];

            for (int i = 0; i < matC.GetLength(0); i++)
            {
                for (int j = 0; j < matC.GetLength(1); j++)
                {
                    matC[i,j] = matA[i,j] * matB[i,j];
                    Console.Write(matC[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
