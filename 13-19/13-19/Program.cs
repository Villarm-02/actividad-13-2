Console.Write("Ingrese número: ");
int menor = int.Parse(Console.ReadLine());

for (int i = 2; i <= 5; i++)
{
    Console.Write("Ingrese número: ");
    int num = int.Parse(Console.ReadLine());

    if (num < menor)
    {
        menor = num;
    }
}

Console.WriteLine($"Menor: {menor}");