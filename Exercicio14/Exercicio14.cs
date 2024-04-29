int[] vet = new int[5];

for (int i = 0; i < vet.Length; i++)
{
    Console.WriteLine($"Informe o {i+1}º valor: ");
    vet[i] = int.Parse(Console.ReadLine());
}


