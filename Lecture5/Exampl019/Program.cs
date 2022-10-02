// Разбить некоторое количество участников на некоторое количество команд
// Есть 5 игроков. Нужно показать разбиение игроков на две команды
// 0 - игрок попадает в первую команду
// 1 - игрок попадает во вторую команду

int n = 1; // n не льзя включить внутрь метода при вызове рекурсии n будет обнуляться.
void FineWords(string alphabet, char[] word, int length = 0)
{
    
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FineWords(alphabet, word, length + 1);
    }
}

FineWords("аисв", new char[4]);


