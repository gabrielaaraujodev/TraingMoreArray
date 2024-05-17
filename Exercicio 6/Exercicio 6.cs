using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    internal class Program
    {
        static void MaioresValoresParaUmaNovaMatriz(int[,] matrizA, int[,] matrizB)
        {
            int[,] matrizMaioresValores = new int[4,4];

            for (int i = 0; i <  matrizA.GetLength(0); i++)
            {
                for(int j = 0; j < matrizB.GetLength(1); j++)
                {
                    if (matrizA[i, j] > matrizB[i, j])
                    {
                        matrizMaioresValores[i,j] = matrizA[i, j];
                    } else
                    {
                        matrizMaioresValores[i,j] = matrizB[i, j];
                    }
                }
            }

            for (int i = 0; i < matrizMaioresValores.GetLength(0); i++)
            {
                for(int j = 0; j < matrizMaioresValores.GetLength(1); j++)
                {
                    Console.Write(matrizMaioresValores[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] matrizA = new int[4,4];
            int[,] matrizB = new int[4,4];

            Random rand = new Random();

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    matrizA[i, j] = rand.Next(1, 21);
                    matrizB[i, j] = rand.Next(1, 21);
                }
            }

            MaioresValoresParaUmaNovaMatriz(matrizA,matrizB);

            Console.ReadLine();
        }
    }
}
