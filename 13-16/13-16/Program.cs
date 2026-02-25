int contador = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingrese número: ");
    int num = int.Parse(Console.ReadLine());

    if (num > 10)
        contador += 1;
}

Console.WriteLine("Mayores que 10: " + contador);