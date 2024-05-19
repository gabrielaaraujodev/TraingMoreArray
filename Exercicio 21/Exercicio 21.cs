using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizA = new double[2,2];
            double[,] matrizB = new double[2,2];
            Random rand = new Random();

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i,j] = rand.Next(1,11);
                    Console.Write(matrizA[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    matrizB[i, j] = rand.Next(1, 11);
                    Console.Write(matrizB[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            bool control = true;
            while (control)
            { 
                Console.WriteLine("Escolha uma opção:\n(a) Somar duas matrizes\n(b) Subtrair a primeira matriz da segunda\n(c) Adicionar uma constante as duas matrizes\n(d) Imprimir as matrizes\n(e) Sair");
                char option = char.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (option) 
                { 
                    case 'a':
                        double[,] matrizSoma = new double[2,2];
                        for (int i = 0; i < matrizSoma.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrizSoma.GetLength(1); j++)
                            {
                                matrizSoma[i,j] = matrizA[i,j] + matrizB[i,j];
                                Console.Write(matrizSoma[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;

                    case 'b':
                        double[,] matrizSubtração = new double[2, 2];
                        for (int i = 0; i < matrizSubtração.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrizSubtração.GetLength(1); j++)
                            {
                                matrizSubtração[i, j] = matrizA[i, j] - matrizB[i, j];
                                Console.Write(matrizSubtração[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;

                    case 'c':
                        Console.WriteLine("Informe a constante para ser adicionada as matrizes: ");
                        double constante = double.Parse(Console.ReadLine());

                        for (int i = 0; i < matrizA.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrizA.GetLength(1); j++)
                            {
                                matrizA[i,j] = matrizA[i, j] + constante;
                                matrizB[i,j] = matrizB[i, j] + constante;
                            }
                        }
                        Console.WriteLine();
                        break;

                     case 'd':
                        for (int i = 0; i < matrizA.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrizA.GetLength(1); j++)
                            {
                                Console.Write(matrizA[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();

                        for (int i = 0; i < matrizA.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrizA.GetLength(1); j++)
                            {
                                Console.Write(matrizB[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;

                    case 'e':
                        control = false;
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
