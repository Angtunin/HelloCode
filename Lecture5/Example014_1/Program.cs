// Собрать строку с числами от a до b, a >= b.

void NambersFor1(int a, int b)
{
    string result1 = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result1 += $"{i} ";
    
    }
    Console.WriteLine(result1); //return result;
}

string NambersRec(int a, int b)
{
    if (b <= a) return NambersRec(a, b + 1) + $"{b} "; 
    else return string.Empty;
}

// Console.WriteLine(NambersFor1(1, 10));
 NambersFor1(10, 1);
Console.WriteLine(NambersRec(10, 1));