// метод для решения факториала

int Factorial(int n) // замена типа int на double может отсрочить переполнение типа
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

// Console.WriteLine(Factorial(5));

for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

double Factorial1(int n) // замена типа int на double может отсрочить переполнение типа
{
    if (n == 1) return 1;
    else return n * Factorial1(n - 1);
}

for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"{i}! = {Factorial1(i)}");
}