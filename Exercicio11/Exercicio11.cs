double[] vet = new double[5];
int cont = 0;
double soma = 0;

for (int i = 0; i < vet.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1} valor: ");
    vet[i] = double.Parse(Console.ReadLine());

    if (vet[i] < 0)
    {
        cont++; 
    } else
    {
        soma += vet[i];
    }

}
    Console.WriteLine("A quantidade de valores negativos é: " + cont);

    Console.WriteLine("A soma dos valores positivos é: " + soma);
