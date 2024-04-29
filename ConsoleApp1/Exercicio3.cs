double[] v = new double[10];
double[] vetor = new double[10];

for (int i = 0; i < v.Length; i++)
{
    Console.WriteLine("Digite um Número");
    v[i] = double.Parse(Console.ReadLine());

    vetor[i] = v[i] * v[i];
}
foreach (int m in vetor)
{
    Console.WriteLine(m + " ");
}
Console.ReadLine();