Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

string ShowSequence(int start, string res)
{
    if ( start <= 0 )
    {
        return res;
    }
    return ( $"{start} \t {ShowSequence(--start, res)} ");
}   
Console.Write(ShowSequence(n," "));