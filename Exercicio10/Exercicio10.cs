double[] vet = new double[15];
double media = 0;

for (int i = 0; i < vet.Length; i++)
{
    Console.WriteLine($"Informe a nota do {i + 1}º alundo: ");
    vet[i] = double.Parse(Console.ReadLine());

    media += vet[i];
}

media = media / vet.Length;

Console.WriteLine("A média da turma é: " + media);

Console.ReadLine();