using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] questoesAlunos = new int[3,10];
            int[] gabarito = new int[10];

            Random random = new Random();

            for (int i = 0; i < questoesAlunos.GetLength(0); i++)
            {
                for (int j = 0; j < questoesAlunos.GetLength(1); j++)
                {
                    questoesAlunos[i, j] = random.Next(1, 5);
                    Console.Write(questoesAlunos[i,j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0;i < gabarito.Length;i++)
            {
                gabarito[i] = random.Next(1, 5);
            }

            foreach (int i in gabarito)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int contador = 0;
            int[] qntAcertos = new int[3];
            for (int i = 0; i < questoesAlunos.GetLength(0); i++)
            {
                contador = 0;
                for (int j = 0; j < questoesAlunos.GetLength(1); j++)
                {
                    if (questoesAlunos[i,j] == gabarito[j])
                    {
                        contador++;
                        qntAcertos[i] = contador;
                    }
                }
            }

            for (int i = 0; i < qntAcertos.Length;i++)
            {
                Console.Write($"O aluno de matrícula: {i+20} \nescolheu as respostas:   \nsua nota final é: {qntAcertos[i]}");
                Console.WriteLine();
                if (qntAcertos[i] * 10 >= 70)
                {
                    Console.Write($"O aluno de matricula {i+20} está aprovado ! ");
                    Console.WriteLine();
                } else
                {
                    Console.Write($"O aluno de matricula {i + 20} está reprovado! ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
