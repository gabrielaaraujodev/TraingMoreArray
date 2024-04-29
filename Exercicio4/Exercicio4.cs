int[] v = new int[8];
int soma, x, y;

for (int i = 0; i < v.Length; i++)
{
    Console.WriteLine("Digite um Número");
    v[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite a primeira posição para a soma");
x = int.Parse(Console.ReadLine());

x = v[x];

Console.WriteLine("Digite a primeira Posição para a Soma");
y = int.Parse(Console.ReadLine());

y = v[y];

soma = x + y;

Console.WriteLine("Total: " + soma);
Console.ReadLine();