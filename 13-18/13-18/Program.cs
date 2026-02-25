Console.Write("Ingrese número: ");
int mayor = int.Parse(Console.ReadLine());

for (int i = 2; i <= 5; i++)
{
    Console.Write("Ingrese número: ");
    int num = int.Parse(Console.ReadLine());

    if (num > mayor)
    {
        mayor = num;
    }
}

Console.WriteLine($"Mayor: {mayor}");