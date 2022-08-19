Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

void ShowSequence(int start)
{
    if ( start <= 0 )
    {
        return;
    }
    else
    {
    Console.Write(start + " ");
    start--;
    ShowSequence(start);
    }
}   
ShowSequence(n);