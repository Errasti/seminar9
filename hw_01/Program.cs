Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

void ShowSequence(int start, int end)
{
    if ( start > end )
    {
        return;
    }
    else
    {
        Console.Write(start + " ");
        start++;
        ShowSequence(start,end);
    }
}

ShowSequence(m,n);