// Перебор слов (букв)
// В некотором машинном алфавите имеются четыре
// буквы а, и, с, и в. Показать все слова,
// состоящие из Т букв, которые можно построить из букв этого алфавита.

// итеративный способ

char[] s = {'а', 'и', 'с', 'в'};

int count = s.Length;
int n = 1;

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{n++, -5}{s[i]}"); // для однобуквенных слов
}

for (int i = 0; i < count; i++)
{
    for(int j = 0; j < count; j++)
    {
        Console.WriteLine($"{n++, -5}{s[i]}{s[j]}"); // для двухбуквенных слов
    } 
}

for (int i = 0; i < count; i++)
{
    for(int j = 0; j < count; j++)
    {
        for(int k = 0; k < count; k++)
        {
            Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}"); // для трёхбуквенных слов
        }
    } 
}