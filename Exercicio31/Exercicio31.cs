using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio31
{
    internal class Exercicio31
    {
        static bool NumeroForaDoVetor(int vetor1, int[] vetUniao)
        {
            for (int i = 0; i < vetUniao.Length; i++)
            {
                if (vetUniao[i] == vetor1) // vetor1 = 2
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] vetA = new int[5];
            int[] vetB = new int[5];

            int[] uniao = new int[vetA.Length * 2];

            Random random = new Random();

            for (int i = 0;i < vetA.Length;i++)
            {
                vetA[i] = random.Next(1, 21);
                vetB[i] = random.Next(1, 21);
            }

            for (int i = 0; i < vetA.Length; i++)
            {
                if (NumeroForaDoVetor(vetA[i], uniao))
                {
                    uniao[i] = vetA[i];
                } 
            }

            for (int i = 0; i < vetB.Length; i++)
            {
                if (NumeroForaDoVetor(vetB[i], uniao))
                {
                    uniao[i + vetA.Length] = vetB[i];
                }
            }

            foreach (int i in vetA)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (int i in vetB)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (int i in uniao)
            {
                Console.Write(i + " ");
            }

           

            int cont = 0;
            foreach (int i in uniao)
            {
                if(i != 0)
                {
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Há {cont} números != de ZERO.");

            int[] vetUniaoFinal = new int[cont];

            int indexvetUniaoFinal = 0;
            for(int i = 0; i < uniao.Length; i++)
            {
                if (uniao[i] != 0)
                {
                    vetUniaoFinal[indexvetUniaoFinal] = uniao[i];
                    indexvetUniaoFinal++;
                }
            }

            Console.WriteLine();


            foreach (int i in vetUniaoFinal)
            {
                Console.Write(i + " ");
            }

            

            Console.ReadLine();
        }
    }
}
