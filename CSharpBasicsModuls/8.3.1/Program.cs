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
    throw new ArgumentException("Файл не найден");//Последний запуск приложения 3/12/2024 10:45:22PM
//Последний запуск приложения 3/12/2024 11:00:27PM
//Последний запуск приложения 3/12/2024 11:00:47PM
//Последний запуск приложения 3/12/2024 11:01:04PM
