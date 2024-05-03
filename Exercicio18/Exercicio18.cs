int[] vet = new int[5];

for (int i = 0; i < vet.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número: ");
    vet[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Informe um número qualquer: ");
int x = int.Parse(Console.ReadLine());

int tamanhoSegundoVetor = 0;
for (int i = 0;i < vet.Length; i++)
{ 
    if (vet[i] % x == 0)
    {
        tamanhoSegundoVetor++;
    }
}

int[] vet2 = new int[tamanhoSegundoVetor];
int cont = 0;

for (int i = 0;i < vet.Length; i++)
{
    if (vet[i] % x == 0)
    {
        vet2[cont] = vet[i]; 
        cont++;
    }
}

foreach (int n in vet2)
{
    Console.Write(n + " ");
}

Console.ReadLine();