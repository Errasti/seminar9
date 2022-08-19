Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

int AkkFunction(int m, int n)
{
    if ( m == 0 )
    {
        return n + 1;
    }
    if ( n == 0 )
    {
        return AkkFunction(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return AkkFunction(m - 1, AkkFunction(m, n - 1));
    }
    return -1;
}
if (AkkFunction(m,n) == -1)
{
    Console.WriteLine("Введите неотрицательные M и N ");
}
else
{
Console.WriteLine("Результат: " + AkkFunction(m,n));
}