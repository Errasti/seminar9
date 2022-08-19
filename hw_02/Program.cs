Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

int ShowSum(int start, int end, int sum)
{

    if (start > end)
    {
        return sum;
    }
    else
    {
        sum += start;
        start++;
        return ShowSum(start, end, sum);
    }
}

Console.WriteLine(ShowSum(m, n, 0));