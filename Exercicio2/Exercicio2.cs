int[] v = new int[6];

for (int i = 0; i < v.Length; i++)
{
    Console.WriteLine("Digite um Número");
    v[i] = int.Parse(Console.ReadLine());
}
foreach (int m in v)
{
    Console.WriteLine(m + " ");
}
Console.ReadLine();