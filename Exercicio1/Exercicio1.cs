int[] A = { 1, 0, 5, -2, -5, 7 };
int soma;

soma = A[0] + A[1] + A[5];

Console.WriteLine("Soma: " + soma);


A[4] = 100;

foreach (int m in A) // 1,2,3,4
{
    Console.WriteLine(m + " ");
}
Console.ReadLine();