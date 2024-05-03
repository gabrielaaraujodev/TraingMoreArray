int[] vet = new int[10];

for(int i = 0; i < vet.Length; i++)
{
    Console.WriteLine($"Informe o {i+1} número: ");
    vet[i] = int.Parse(Console.ReadLine());

    if (vet[i] < 0 )
    {
        vet[i] = 0;
    }
}

foreach(int n in vet)
{
    Console.Write(n + " ");
}

Console.ReadLine();