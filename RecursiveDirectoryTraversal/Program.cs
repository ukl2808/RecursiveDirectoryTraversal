Console.Write("Введите путь к каталогу: ");
string path = Console.ReadLine();

TraverseDirectory(path);

Console.WriteLine("Обход завершен.");

static void TraverseDirectory(string directory)
{
    try
    {
        string[] files = Directory.GetFiles(directory);
        string[] subdirectories = Directory.GetDirectories(directory);

        Console.WriteLine($"Файлы в каталоге {directory}:");
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

        Console.WriteLine($"Подкаталоги в каталоге {directory}:");
        foreach (string subdirectory in subdirectories)
        {
            Console.WriteLine(subdirectory);
            TraverseDirectory(subdirectory);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка при обходе каталога {directory}: {ex.Message}");
    }
}