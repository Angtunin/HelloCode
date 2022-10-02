int a = 10;
int b = 1;

string result = string.Empty;

for (int i = a; i >= b; i--)
{
    result += $"{i} ";
    
}
Console.Write(result);


Console.WriteLine();


int c = 1;
int d = 10;
string result1 = string.Empty;
int j = c;
while ( j <= d)
{
    result1 += $"{j} ";
    j++;
}
Console.Write(result1);
