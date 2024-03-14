GetCatalogs(); //   Вызов метода получения директории

Console.WriteLine();
CountObjects();
CreateDirectory("Test");

static void GetCatalogs()
{
    string dirName = @"/"; // Прописываем путь к корневой директории MacOS
    if (Directory.Exists(dirName)) // Проверим, что директория существует
    {
        Console.WriteLine("Папки:");
        string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

        foreach (string d in dirs) // Выведем их все
            Console.WriteLine(d);

        Console.WriteLine();
        Console.WriteLine("Файлы:");
        string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

        foreach (string s in files)   // Выведем их все
            Console.WriteLine(s);
    }
}

static void CountObjects()
{
    string dirName = @"/"; // Прописываем путь к корневой директории MacOS
    if (Directory.Exists(dirName)) // Проверим, что директория существует
    {
        Console.WriteLine("Количество папок:");
        string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

        Console.WriteLine(dirs.Length);

        Console.WriteLine();
        Console.WriteLine("Количество файлов:");
        string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

        Console.WriteLine(files.Length);

        Console.WriteLine();
        Console.WriteLine("Общее количество объектов:");
        Console.WriteLine(dirs.Length + files.Length);
    }
}

static void CreateDirectory()
{
    try
    {
        DirectoryInfo dirInfo = new DirectoryInfo(@"/");
        if (dirInfo.Exists)
        {
            Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
        }

        DirectoryInfo newDirectory = new DirectoryInfo(@"/newDirectory");
        if (!newDirectory.Exists)
            newDirectory.Create();

        Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}