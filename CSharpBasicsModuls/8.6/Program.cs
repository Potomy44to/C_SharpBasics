//Задание 1
string pathTask1 = @"/Users/s.hlestunov/Repositories/FolderWithFilesCopy";
ClearFolder(pathTask1);

static void ClearFolder(string path)
{
    DirectoryInfo folder = new DirectoryInfo(path);

    if (folder.Exists)
    {
        try
        {
            var files = folder.GetFiles();
            foreach (var file in files)
            {
                if (CheckTimeOfUse(file))
                    file.Delete();
            }
            foreach (var dir in folder.GetDirectories())
            {
                ClearFolder(dir.FullName);
                if (CheckTimeOfUse(dir) && (dir.GetFiles().Length == 0 && dir.GetDirectories().Length == 0))
                    dir.Delete(true);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
    else
        Console.WriteLine("Папка не существует");
}

static bool CheckTimeOfUse(FileSystemInfo item)
{
    bool result;
    DateTime now = DateTime.Now;
    DateTime last = item.LastAccessTime;
    TimeSpan timeInterval = TimeSpan.FromMinutes(1);
    TimeSpan difference = now.Subtract(last);
    if (difference > timeInterval)
        result = true;
    else
        result = false;
    return result;
}


//Задание 2
string pathTask2 = @"/Users/s.hlestunov/Repositories/FolderWithFiles";

Console.WriteLine("Размер папки = " + GetFolderSize(pathTask2) + " байт");

static long GetFolderSize(string dirName)
{
    long sizeSum = 0;
    DirectoryInfo dir = new DirectoryInfo(dirName);
    if (dir.Exists)
    {
        try
        {
            var files = dir.GetFiles();
            foreach (var file in files)
            {
                sizeSum += file.Length;
            }
            foreach (var di in dir.GetDirectories())
            {
                sizeSum += GetFolderSize(di.FullName);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
    else
        Console.WriteLine("Папка не существует");

    return sizeSum;
}


//Задание 3
long initialSize = GetFolderSize(pathTask1);

Console.WriteLine("Исходный размер папки: " + initialSize + " байт");

ClearFolder(pathTask1);
long currentSize = GetFolderSize(pathTask1);

Console.WriteLine("Освобождено: " + (initialSize - currentSize) + " байт");
Console.WriteLine("Текущий размер папки: " + GetFolderSize(pathTask1) + " байт");


//Задание 4
string pathTask4 = @"/Users/s.hlestunov/Repositories/Students";
string filePath = @"/Users/s.hlestunov/Repositories/students.dat";

List<Student> studentsList = new List<Student>
{
    new Student { Name = "Жульен", Group = "G1", DateOfBirth = new DateTime(2001, 10, 22), AverageScore = 3.3M },
    new Student { Name = "Боб", Group = "G1", DateOfBirth = new DateTime(1999, 5, 25), AverageScore = 4.5M},
    new Student { Name = "Лилия", Group = "F2", DateOfBirth = new DateTime(1999, 1, 11), AverageScore = 5M},
    new Student { Name = "Роза", Group = "F2", DateOfBirth = new DateTime(1989, 9, 19), AverageScore = 3.7M}
};

if (!Directory.Exists(pathTask4))
{
    Directory.CreateDirectory(pathTask4);
}

WriteFile(studentsList, filePath);
DisplayData(filePath);

static void WriteFile(List<Student> students, string file)
{
    if(File.Exists(file))
    {
        using (var stream = File.Open(file, FileMode.Create))
        {
            using (var writer = new BinaryWriter(stream))
            {
                foreach (Student student in students)
                {
                    writer.Write(student.Name);
                    writer.Write(student.Group);
                    writer.Write(student.DateOfBirth.ToBinary());
                    writer.Write(student.AverageScore);
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Файл не найден");
    }

}

static void DisplayData(string file)
{
    if (File.Exists(file))
    {
        using (var stream = File.Open(file, FileMode.Open))
        {
            using (var reader = new BinaryReader(stream))
            {

                while (stream.Position < stream.Length)
                {
                    Student student = new Student();
                    student.Name = reader.ReadString();
                    student.Group = reader.ReadString();
                    long dt = reader.ReadInt64();
                    student.DateOfBirth = DateTime.FromBinary(dt);
                    student.AverageScore = reader.ReadDecimal();

                    Console.WriteLine("Имя: " + student.Name + ", Группа: " + student.Group + ", Дата рождения: " + student.DateOfBirth.ToShortDateString() + ", Средний балл: " + student.AverageScore);
                }

            }
        }
    }
    else
    {
        Console.WriteLine("Файл не найден");
    }

}

class Student
{
    public string Name { get; set; }
    public string Group { get; set; }
    public DateTime DateOfBirth { get; set; }
    public decimal AverageScore { get; set; }
}

