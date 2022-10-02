// Обход дериктории (просмотр содержимого папок);

void CatalogInfo(string path, string indent = "")
{
    
    DirectoryInfo catalog = new DirectoryInfo(path);// получаем информацию о директории
    DirectoryInfo[] catalogs = catalog.GetDirectories(); //получаем массив всех папок и циклом проходим по нему
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = @"D:/1/Проекты/GeekBrains/С(шарп)/Lecture";
CatalogInfo(path);
