using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] notas = new double[10, 3];
            Random random = new Random();

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    notas[i, j] = random.Next(1,4);
                    Console.Write(notas[i, j] + "\t ");
                }
                Console.WriteLine();
            }


            int piorNota1 = 0;
            int piorNota2 = 0;
            int piorNota3 = 0;
            double menor = double.MaxValue;
            double[] pioresNotasAlunos = new double[10];
            
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                menor = double.MaxValue;
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (notas[i, j] < menor)
                    {
                        menor = notas[i, j];
                    }

                    if (menor == notas[, j])
                    {
                        piorNota1++;
                        pioresNotasAlunos[i] = menor;
                    }
                    else if (menor == notas[0, j])
                    {
                        piorNota2++;
                        pioresNotasAlunos[i] = menor;
                    }
                    else
                    {
                        piorNota3++;
                        pioresNotasAlunos[i] = menor;
                    }
                } 
            }

            foreach (int i in pioresNotasAlunos)
            {
                Console.Write(i + " ");
            }

            // O desempate vai ser dar pelo peso intrínseco de cada nota


            Console.ReadLine();
        }
    }
}
