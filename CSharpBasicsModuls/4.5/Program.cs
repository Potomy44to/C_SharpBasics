(string firstName, string secondName, string login, int loginLength, bool havePet, double age, string[] favouriteColors) User;

for (int k = 0; k < 3; k++)
{
    Console.WriteLine("Введите имя");
    User.firstName = Console.ReadLine();

    Console.WriteLine("Введите фамилию");
    User.secondName = Console.ReadLine();

    Console.WriteLine("Введите логин");
    User.login = Console.ReadLine();

    User.loginLength = User.login.Length;

    Console.WriteLine("Есть ли у вас животные? Да или Нет");

    switch (Console.ReadLine())
    {
        case "Да":
        case "да":
            {
                User.havePet = true;
                break;
            }
        default:
            {
                User.havePet = false;
                break;
            }
    }

    Console.WriteLine("Введите возраст пользователя");
    User.age = double.Parse(Console.ReadLine());

    User.favouriteColors = new string[3];

    Console.WriteLine("Введите три любимых цвета пользователя");

    for (int i = 0; i < 3; i++)
    {
        User.favouriteColors[i] = Console.ReadLine();
    }
}