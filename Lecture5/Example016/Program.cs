// Нахождение факториала числа.

int FactorialFor(int a)
{
    int result = 1;
    for(int i = 1; i <= a; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if ( n == 1 || n == 0) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(5));
Console.WriteLine(FactorialRec(5));
