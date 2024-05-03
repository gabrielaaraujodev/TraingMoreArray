Random n = new Random();


int[] vet =  new int[5];
int tamanhoSegundaVetor = 0;

for (int i = 0; i < vet.Length; i++)
{
    vet[i] = n.Next(0, 51);
    
    if (vet[i] % 2 != 0)
    {
        tamanhoSegundaVetor++;
    }
}

int[] vet2 = new int[tamanhoSegundaVetor];
int cont = 0;

for (int i = 0; i < vet.Length; i++)
{
    if (vet[i] % 2 != 0)
    {
        vet2[cont] = vet[i];
        cont++;
    }
}

Console.ReadLine();