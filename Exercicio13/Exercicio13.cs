int[] vet = new int[5];
int maior = 0, menor = 0, maiorPos = 0, menorPos = 0;

Console.WriteLine($"Informe o 1º valor: ");
vet[0] = int.Parse(Console.ReadLine());

maior = vet[0];
menor = vet[0];

for (int i = 1; i < vet.Length; i++)
{
    Console.WriteLine($"Informe o {i+1}º valor: ");
    vet[i] = int.Parse(Console.ReadLine());

    if (vet[i] > maior)
    {
        maior = vet[i];
        maiorPos = i;
    }

    if (vet[i] < menor)
    {
        menor = vet[i]; 
        menorPos = i;
    }

}

    Console.WriteLine("");
    Console.Write("O maior número é: " + maior + " e sua posição é: " + maiorPos);
    Console.WriteLine("");
    Console.Write($"O maior número é: " + menor + " e sua posição é: " + menorPos);

Console.ReadLine();