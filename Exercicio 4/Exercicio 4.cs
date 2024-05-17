using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Program
    {
        static int MaiorValorDaMatriz(int[,] matriz)
        {
            int maiorValor = matriz[0,0];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (maiorValor < matriz[i,j])
                    {
                         maiorValor = matriz[i,j];
                    } 
                }
            }

            return maiorValor;
        }

        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Informe um valor para matriz: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine(MaiorValorDaMatriz(matriz));

            Console.ReadLine();
        }
    }
}
