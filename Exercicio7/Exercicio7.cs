double[] vet = new double[10];
double maior;
int pos = 0;

Random numbers = new Random();

vet[0] = numbers.Next(1, 50);
maior = vet[0];

for (int i = 1; i < vet.Length; i++)
{
    vet[i] = numbers.Next(1,50);
    Console.WriteLine(vet[i]);

    if (vet[i] > maior)
    {
        maior = vet[i];
        pos = i;
    }
}

Console.WriteLine("O maior valor é: " + maior + " e sua posição no Array é: " + pos);

Console.ReadLine();