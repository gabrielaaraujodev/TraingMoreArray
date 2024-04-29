int[] vet = new int[6];
Random r = new Random();  


for (int i = 0; i < vet.Length; i++)
{
    vet[i] = r.Next(1, 20);
    Console.WriteLine(vet[i]);
}

for (int i = 5;i >= 0; i--)
{
    Console.Write(vet[i] + " ");
}

Console.ReadLine();