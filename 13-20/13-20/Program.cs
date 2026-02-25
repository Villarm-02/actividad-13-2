Console.Write("¿Cuántos números?: ");
int n = int.Parse(Console.ReadLine());
int positivos = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese un número: ");
    int num = int.Parse(Console.ReadLine());
    if (num > 0)
    { 
    positivos += 1;
    }
}

Console.WriteLine("Positivos: " + positivos);