(string name, string surname, byte age, string[]? namePets, string[] favouriteColors) userData;
userData = UserInformation();

Console.WriteLine("Информация по пользователю:");

PrintInformation(userData);

static (string name, string surname, byte age, string[]? namePets, string[] favouriteColors) UserInformation()
{
    (string name, string surname, byte age, string[] namePets, string[] favouriteColors) User;
    bool isByteNumber;
    User.namePets = null;
    byte numberPets;

    Console.WriteLine("Введите имя:");
    User.name = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("Введите фамилию:");
    User.surname = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("Введите количество полных лет:");

    User.age = 0;
    for(bool checkResult = false; checkResult == false;)
    {
        isByteNumber = Byte.TryParse(Console.ReadLine(), out User.age);
        checkResult = CheckEnteredNumber(User.age);

        if (!checkResult)
           Console.WriteLine("Введите число от 1 до 200");
        else break;
    }

    Console.WriteLine();

    Console.WriteLine("У вас есть питомец? (да/нет):");
    switch(Console.ReadLine())
    {
        case "Да":
        case "да":
            {
                Console.WriteLine("Сколько у вас питомцев?");

                for (bool checkResult = false; checkResult == false;)
                {
                    isByteNumber = Byte.TryParse(Console.ReadLine(), out numberPets);
                    checkResult = CheckEnteredNumber(numberPets);

                    if (!checkResult)
                        Console.WriteLine("Введите число от 1 до 200");
                    else
                    {
                        User.namePets = InputNamePets(numberPets);
                        break;
                    };
                }

                break;
            }
        default:
            {
                break;
            }
    }

    Console.WriteLine();

    Console.WriteLine("Введите количество любимых цветов:");

    byte numberColors = 0;

    for (bool checkResult = false; checkResult == false;)
    {
        isByteNumber = Byte.TryParse(Console.ReadLine(), out numberColors);
        checkResult = CheckEnteredNumber(numberColors);

        if (!checkResult)
            Console.WriteLine("Введите число от 1 до 200");
        else break;

    }

    User.favouriteColors = InputFavouriteColors(numberColors);

    Console.WriteLine();

    return (User.name, User.surname, User.age, User.namePets, User.favouriteColors);

}

static string[] InputNamePets(byte number)
{
    string[] userPets = new string[number];

    if(number > 0)
    {
        Console.WriteLine("Напишите по очереди имена питомцев:");
        for (int i = 0; i < number; i++)
        {
            userPets[i] = Console.ReadLine();
        }

        return userPets;
    }
    else return null;
}

static string[] InputFavouriteColors(byte number)
{
    string[] userColors = new string[number];

    Console.WriteLine("Напишите по очереди любимые цвета:");
    for (int i = 0; i < number; i++)
    {
        userColors[i] = Console.ReadLine();
    }

    return userColors;
}

static bool CheckEnteredNumber(byte number)
{
    if (0 < number && number <= 200)
    {
        return true;
    }
    else return false;
}

static void PrintInformation((string name, string surname, byte age, string[] namePets, string[] favouriteColors) User)
{
    Console.WriteLine("Имя - {0}", User.name);
    Console.WriteLine("Фамилия - {0}", User.surname);
    Console.WriteLine("Возраст - {0}", User.age);

    Console.WriteLine();

    if (User.namePets != null)
    {
        Console.WriteLine("Питомцы - есть\nИх имена:");

        foreach (string name in User.namePets)
        {
            Console.WriteLine(name);
        }
    }
    else
    {
        Console.WriteLine("Питомцы - нет");
    }

    Console.WriteLine();
    Console.WriteLine("Любимые цвета:");

    foreach (string color in User.favouriteColors)
    {
        Console.WriteLine(color);
    }
}
