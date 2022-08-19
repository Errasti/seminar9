Console.WriteLine("Введите значение A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение B: ");
int b = int.Parse(Console.ReadLine());

double Pow(int n, int p)
{
    if ( p < 0 )
    {
        return 1 / Pow(n,-p);
    }
    if (p == 1)
    {
        return n;
    }
    if (p == 0)
    {
        return 1;
    }
    return n * Pow(n, --p);
}

Console.WriteLine(Pow(a,b));