Console.Write("Cantidad de ventas: ");
int n = int.Parse(Console.ReadLine());
double total = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("De cuento fue la venta: ");
    total += double.Parse(Console.ReadLine());
}

Console.WriteLine("Total vendido: " + total);