int[] vet = new int[6];
int i = 0, atual; 

Random numbers = new Random();


while (i < vet.Length)
{
    atual = numbers.Next(1, 50);
    
    if (atual % 2 == 0)
    {
        vet[i] = atual;
        i++;
    } 
}

Console.WriteLine("");

for (i = 5; i >= 0; i--)
{
    Console.Write(vet[i] + " ");
}

Console.ReadLine();
