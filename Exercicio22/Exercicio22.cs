int[] vetA = new int[5];
int[] vetB = new int[5];

int[] vetC = new int[10];

for (int i = 0; i < vetA.Length; i++)
{
    Console.WriteLine("Informa um valor para o vetor A: ");
    vetA[i] = int.Parse(Console.ReadLine());

    Console.WriteLine("Informa um valor para o vetor B: ");
    vetB[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();

for (int i = 0, j = 1,c = 0; i < vetC.Length; i = i+2, j = j+2, c++)
{
    vetC[i] = vetA[c];

    vetC[j] = vetB[c];
}

Console.WriteLine();

foreach (int n in vetC)
{
    Console.Write(n + " ");
}

Console.ReadLine();
