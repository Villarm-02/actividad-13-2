int suma = 0;
for (int i = 1; i <= 3; i++)
{
    Console.Write("Ingrese un número: ");
    int num = int.Parse(Console.ReadLine());
    suma += num;
}
Console.WriteLine(suma);