double[] vet = new double[5];
int option;

for (int i = 0; i < vet.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º valor: ");
    vet[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("0 - Finalizar ");
Console.WriteLine("1 - Vetor na ordem crescente ");
Console.WriteLine("2 - Vetor na ordem inversa ");
option = int.Parse(Console.ReadLine());

switch (option)
{
    case 0:
        Console.WriteLine("Programa finalizado !");
        break;
    case 1:
        foreach (double v in vet)
        {
            Console.Write(v + " ");
        }
        break;
    case 2:
        for (int i = 4; i >= 0; i--)
        {
            Console.WriteLine(vet[i] + " ");
        }
        break;
    default:
        Console.WriteLine("Código Inválido !");
        break;
}

Console.ReadLine();