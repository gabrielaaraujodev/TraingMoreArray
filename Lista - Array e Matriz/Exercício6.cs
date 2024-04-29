double[] vet = new double[10];

double minimo, maximo, atual;

Random numbers = new Random();

vet[0] = numbers.Next(1, 50);

atual = vet[0];
minimo = vet[0];
maximo = vet[0];

Console.WriteLine(atual);
for (int i = 1; i < vet.Length; i++)
{
    atual = numbers.Next(1, 50);

    Console.WriteLine(atual);

    if (atual < minimo)
    {
        minimo = atual;
    }

    if (atual > maximo)
    {
        maximo = atual;   
    }
}

Console.WriteLine("minimo " + minimo);
Console.WriteLine("maximo " + maximo);

Console.ReadLine();