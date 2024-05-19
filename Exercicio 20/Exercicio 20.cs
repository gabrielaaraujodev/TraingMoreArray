using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[3,6];
            Random rand = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = rand.Next(1,11);
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }

            double somaColunasImpares = 0;
            for (int i = 1; i < matriz.GetLength(1); i = i + 2)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    somaColunasImpares += matriz[j,i];

                }
            }

            Console.WriteLine();
            Console.WriteLine($"A soma dos elementos das colunas ímpares é: {somaColunasImpares}");

            double somaColunasDoisEhQuatro = 0;
            for (int i = 2; i < matriz.GetLength(1); i = i + 2)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    somaColunasDoisEhQuatro += matriz[j,i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"A média dos elementos das colunas 2 e 4 são: {somaColunasDoisEhQuatro / (matriz.GetLongLength(0) * 2)}");

            Console.WriteLine();

            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 5] = matriz[i,1] + matriz[i,2];
            }
            Console.WriteLine();  

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
