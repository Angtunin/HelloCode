// Собрать строку с числами от a до b, a <=b.

string NambersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} "; // собираем строку с результирующеми значениями счётчика
    }
    return result;
}

string NambersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NambersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NambersFor(1, 10));
Console.WriteLine(NambersRec(1, 10));
