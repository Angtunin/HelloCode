// Парсинг входной строки в массив чисел (кортежи)
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        string text = "(1,2) (2,3) (4,5) (6,7)"
                        .Replace("(", "") // убираем левую скобку вместо неё ничего не добавляем
                        .Replace(")", "")
                        ;

        var data = text.Split(" ") // не явная типизация
                        .Select(item => item.Split(",")) // делаем выборку из двух чисел и на её основе получаем массив
                        .Select(e => (int.Parse(e[0]), int.Parse(e[1]))) // 2. преобразуем массив строк в кортеж чисел
                        .ToArray();

        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine(data[i]);
            // for (int j = 0; j < data[i].Length; j++) цикл преобразования не нужен сделан в операции 2.
            // {
            //     Console.WriteLine(data[i][j]);    
            // }
            Console.WriteLine();
        }
    }
}