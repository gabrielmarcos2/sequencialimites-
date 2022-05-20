Console.Write("Incio: ");
int inicio = Convert.ToInt32(Console.ReadLine());

Console.Write("fim: ");
int fim  = Convert.ToInt32(Console.ReadLine());

if (fim >= inicio)
{
    int n = inicio;

    while (n <= fim)
    {
        Console.Write($"{n} ");
        n += 1;
    }
}
else
{
    Console.WriteLine("Não é possivel terminar antes de iniciar ");
}
