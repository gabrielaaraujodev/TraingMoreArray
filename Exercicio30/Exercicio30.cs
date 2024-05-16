using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio30
{
    internal class Exercicio30
    {

        static bool Verificacao(int vetor1, int [] vetInters)
        {
            for (int i = 0; i < vetInters.Length; i++)
            {
                if (vetInters[i] == vetor1)
                {
                    return false;
                } 
            }
                 return true;
        }

        static void Main(string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];

            int[] vetIntersec = new int[10];

            Random rand = new Random();

            for (int i = 0; i < vet1.Length; i++)
            {
                vet1[i] = rand.Next(1,21);
                vet2[i] = rand.Next(1,21);
            }

            foreach (int um in vet1)
            {
                Console.Write(um + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (int dois in vet2)
            {
                Console.Write(dois + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < vet1.Length; i++)
            {
                for (int j = 0; j < vet2.Length; j++)
                {
                    if (vet1[i] == vet2[j] && Verificacao(vet1[i], vetIntersec))
                    {
                        vetIntersec[i] = vet1[i];
                    }
                }
            }

            foreach (int n in vetIntersec)
            {
                Console.Write(n + " ");
            }

            Console.ReadLine();
        }
    }
}
