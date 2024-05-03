int[] vet = new int[50];

for (int i = 0; i< vet.Length; i++)
{
    vet[i] = (i + (5 * i)) % (i + 1);    
}

foreach (int n in vet)
{
    Console.Write(n + " ");
}

Console.ReadLine();