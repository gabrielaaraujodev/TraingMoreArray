using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 4];

            for (int i = 0; i < matriz.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matriz.GetLength(1) - 1 ; j++)
                {
                    Console.WriteLine($"Informe o número de matrícula, média das provas e média dos trabalhos do {i + 1}º aluno: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matriz.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matriz.GetLength(1) - 1; j++)
                {
                    matriz[i, matriz.GetLength(1) - 1] += matriz[i, j];
                }
            }

            int maior = int.MinValue, matricula = 0;
            for(int i = 0;i < matriz.GetLength(1) + 1; i++)
            {
                if (matriz[i,matriz.GetLength(1) - 1] > maior)
                {
                    maior = matriz[i, matriz.GetLength(1) - 1];
                    matricula = i;
                }
            }
            Console.WriteLine($"A matrícula do aluno que obteve a maior nota final é: {matricula}");

            int soma = 0;
            for (int i = 0; i < matriz.GetLength(1) + 1; i++)
            {
                soma += matriz[i, matriz.GetLength(1) - 1];
            }

            Console.WriteLine($"A média aritimética das médias finais é: {soma / 5.0}");
            Console.ReadLine();
        }
    }
}
