string filePath = @"/Users/s.hlestunov/Repositories/C_SharpBasics/CSharpBasicsModuls/8.3.1/Program.cs";

if (File.Exists(filePath))
{
    using (StreamReader sr = File.OpenText(filePath))
    {
        string str = "";
        while ((str = sr.ReadLine()) != null)
        {
            Console.WriteLine(str);
        }
    }
}
else
    throw new ArgumentException("Файл не найден");

Console.WriteLine();
using (StreamWriter sw = File.AppendText(filePath))
{
    sw.WriteLine("//Последний запуск приложения " + DateTime.Now);
}