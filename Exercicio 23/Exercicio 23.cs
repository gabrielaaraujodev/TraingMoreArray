using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matA = new double[3, 3];
            double[,] matB = new double[3, 3];
            Random random = new Random();

            for (int i = 0; i < matA.GetLength(0); i++)
            {
                for (int j = 0; j < matA.GetLength(1); j++)
                {
                    matA[i, j] = random.Next(1, 11);
                }
            }

            for (int i = 0; i < matB.GetLength(0); i++)
            {
                for (int j = 0; j < matB.GetLength(1); j++)
                {
                    matB[i,j] = Math.Pow(matA[i,j], 2);
                    Console.Write(matB[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
