int[] v = new int[10];

for (int i = 0; i < v.Length; i++)
{
    Console.WriteLine("Digite um Número");
    v[i] = int.Parse(Console.ReadLine());
}
foreach (int m in v)
{
    if (m % 2 == 0)
    {
        Console.Write(m + " ");
    }
}
Console.ReadLine();