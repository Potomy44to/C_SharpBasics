//Задание 1
string folderPath = @"/Users/s.hlestunov/Repositories/FolderWithFilesCopy";

if(Directory.Exists(folderPath))
{
    try
    {
        DeleteFolder(folderPath);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Не удалось очистить папку. {e.Message}");
    }
}
else
    Console.WriteLine("Папка не найдена");


static void DeleteFolder(string path)
{
    string[] dirs = Directory.GetDirectories(path);

    //Если в папке найдена папка или несколько, то проверяем наличие папки внутри, если нет, удалем файлы, затем папку
    if (!(dirs.Length == 0))
    {
        foreach(string dir in dirs)
        {
            DeleteFolder(dir);
        }
    }
    else
    {
        string[] files = Directory.GetFiles(path);

        foreach(string file in files)
        {
            File.Delete(file);
        }

        Directory.Delete(path);
    }
}