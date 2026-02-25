Console.Write("Ingrese la altura de la escalera: ");
int altura = int.Parse(Console.ReadLine());
for (int i = 1; i <= altura; i++)
{
    for (int d = 1; d<= i;d++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}