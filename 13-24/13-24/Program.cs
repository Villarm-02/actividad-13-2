Console.Write("Cantidad de notas: ");
int n = int.Parse(Console.ReadLine());
double suma = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese la nota: ");
    suma += double.Parse(Console.ReadLine());
}

double promedio = suma / n;

if (promedio >= 61)
{
    Console.WriteLine("Aprobado con: " + promedio);
}
else
{
    Console.WriteLine("Reprobado con: " + promedio);
}