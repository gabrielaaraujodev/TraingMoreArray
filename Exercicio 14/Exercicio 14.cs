using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14
{
    internal class Program
    {
            static bool ValorAtualTemNaMatriz(int[,] cartelaBingo, int valorAtual)
            {
                for(int i = 0; i < cartelaBingo.GetLength(0); i++)
                {
                    for (int j = 0; j < cartelaBingo.GetLength(1); j++)
                    {
                        if (valorAtual == cartelaBingo[i, j])
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
        static void Main(string[] args)
        {

            int[,] cartelaBingo = new int[3, 3];
            Random random = new Random();

            for (int i = 0; i < cartelaBingo.GetLength(0); i++)
            {
                for (int j = 0; j < cartelaBingo.GetLength(1); j++)
                {
                    cartelaBingo[i, j] = random.Next(1, 11);

                    if(ValorAtualTemNaMatriz(cartelaBingo, cartelaBingo[i, j]))
                    {
                        cartelaBingo[i, j] = random.Next(1, 11);
                    }

                    Console.Write(cartelaBingo[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
