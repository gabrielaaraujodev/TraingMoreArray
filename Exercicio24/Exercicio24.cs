using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio24
{
    internal class Exercicio24
    {
        static void Main(string[] args)
        {
            double menor, maior;
            Dictionary<int, double> alunos = new Dictionary<int, double>();

            alunos.Add(0, 1.60);
            alunos.Add(1, 1.55);
            alunos.Add(2, 1.70);
            alunos.Add(3, 1.80);
            alunos.Add(4, 1.77);
            alunos.Add(5, 1.82);
            alunos.Add(6, 1.90);
            alunos.Add(7, 1.74);
            alunos.Add(8, 1.61);
            alunos.Add(9, 1.96);

            menor = alunos[1];
            maior = alunos[1];

            for (int i = 1; i < alunos.Count; i++)
            {
                if (alunos[i] <  menor)
                {
                    menor = alunos[i];
                }

                if (alunos[i] > maior)
                {
                    maior = alunos[i];
                }
            }
 
            Console.WriteLine($"O aluno menor aluno mede: " + menor);
            Console.WriteLine("O maior aluno mede: " + maior);

            Console.ReadLine();
        }
    }
}
