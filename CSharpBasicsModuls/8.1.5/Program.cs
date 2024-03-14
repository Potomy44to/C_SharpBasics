using System.IO;

class Disk
{
    public string diskName { get; }
    public long size { get; }
    public long freeDiskPlace { get; }

    public Disk(string diskName, long size, long freeDiskPlace)
    {
        this.diskName = diskName;
        this.size = size;
        this.freeDiskPlace = freeDiskPlace;
    }

    public void GetDiskInfo()
    {
        Console.WriteLine($"Название диска: {diskName}\nОбъем диска: {size}\nСвободное место на диске: {freeDiskPlace}");
    }
}

public class Folder
{
    public List<string> Files { get; set; } = new List<string>();

    Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

    public void CreateFolder(string folderName)
    {
        Folders.Add(folderName, new Folder());
    }
}