(string Name, string[] Dishes) User;

User.Dishes = new string[5];

Console.WriteLine("Как вас зовут?");
User.Name = Console.ReadLine();

Console.WriteLine("Напишите 5 ваших любимых блюд");
for (int i = 0; i < 5; i++)
{
    User.Dishes[i] = Console.ReadLine();
}

Console.WriteLine($"Имя пользователя - {User.Name}");
Console.WriteLine("Любимые блюда пользователя:");

foreach (string dish in User.Dishes)
{
    Console.WriteLine($"{dish}");
}