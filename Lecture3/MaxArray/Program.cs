// Произвести сортировку массива от max к min

int[] arr = {1, 2, 3, 3, 5, 9, 2, 6, 10};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMax(int[] array)
{
    for ( int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary; 
    }
}


PrintArray(arr);
SelectionSortMax(arr);
PrintArray(arr);