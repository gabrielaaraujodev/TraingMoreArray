int[] vet = new int[5];
int maior = 0,menor = 0, media = 0;

Console.WriteLine("Informe o 1º valor: ");
vet[0] = int.Parse(Console.ReadLine());

maior = vet[0];
menor = vet[0];
media = vet[0];

for (int i = 1; i < vet.Length; i++)
{
    Console.WriteLine($"Informe o {i+1}º valor: ");
    vet[i] = int.Parse(Console.ReadLine());

    if (vet[i] > maior)
    {
        maior = vet[i];
    }

    if (vet[i] < menor)
    {
        menor = vet[i];
    }

    media += vet[i];
}

media = media / vet.Length;

foreach (int i in vet)
{
    Console.Write(i + " ");
}

Console.WriteLine("");

Console.WriteLine("O maior número será: " + maior);

Console.WriteLine("O menor número será: " + menor);

Console.WriteLine("O média será: " + media);