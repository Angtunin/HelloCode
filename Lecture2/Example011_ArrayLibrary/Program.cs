void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // в index начиная с 0 присваеваем цифры с 1 по 10 (10 не включается)
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // переменная для записи результата

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;// добавляем для выхода при поиски первого вхождения
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай новый массив в котором будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine(); // выводим пустую строку для отделения вывода массива от результата

int pos = IndexOf(array, 4);
Console.WriteLine(pos);