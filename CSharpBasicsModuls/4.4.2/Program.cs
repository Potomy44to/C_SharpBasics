(string name, int age) anketa;

Console.WriteLine("Enter your name:");
anketa.name = Console.ReadLine();

Console.WriteLine("Enter your age:");
anketa.age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше имя: {0}", anketa.name);
Console.WriteLine("Ваш возраст: {0}", anketa.age);