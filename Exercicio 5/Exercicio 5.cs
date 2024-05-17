using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Informe um valor para matriz: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Informe um valor aleátório: ");
            int randomValue = int.Parse(Console.ReadLine());

            for (int i = 0;i < matriz.GetLength(0); i++)
            {
                for(int j = 0;j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] == randomValue)
                    {
                        Console.WriteLine($"Este número se encontra na matriz na posição [{i},{j}].");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
