double suma = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingrese un número: ");
    double num = double.Parse(Console.ReadLine());
    suma += num;
}
double promedio = suma / 5;
Console.WriteLine($"Su promedio es: {promedio}");