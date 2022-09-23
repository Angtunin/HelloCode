// Работа с двумерным строковым массивом

string[,] table = new string[2, 5];
table[0, 0] = "слово";
table[0, 1] = "слово";
table[0, 4] = "слово";
table[1, 0] = "слово";
table[1, 2] = "слово";
table[1, 4] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.Write($"-{table[rows, columns]}-");
//     }
// Console.WriteLine();
// }

// числовой массив
int[,] matrix = new int[3, 4];

for (int rows = 0; rows < 3; rows++) // для указания row < 3 м. использовать row < matrix.GetLength(0) 0 для строк, 1 для стобцов
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        Console.Write($"{matrix[rows, columns]} ");
    }
    Console.WriteLine();
}