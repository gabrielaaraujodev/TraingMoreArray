using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio34
{
    internal class Exercicio34
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];
            int cont = 0;

            while (cont < vet.Length)
            {
                Console.WriteLine($"Informe o {cont + 1} valor: ");
                vet[cont] = int.Parse(Console.ReadLine());

                for (int i = 0; i < cont; i++)
                {
                    while (vet[cont] == vet[i])
                    {
                        Console.WriteLine($"Informe o {cont + 1} valor: ");
                        vet[cont] = int.Parse(Console.ReadLine());
                    }
                }

                cont++;
            }

            Console.ReadLine();
        }
    }
}
