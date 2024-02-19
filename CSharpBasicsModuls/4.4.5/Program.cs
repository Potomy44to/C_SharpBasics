(string Name, string Type, double Age, int NameCount) Pet;

Console.Write("Введите имя вашего питомца: ");
Pet.Name = Console.ReadLine();

Pet.NameCount = Pet.Name.Length;

Console.Write("Введите тип вашего питомца (собака, рыбка, хомячок): ");
switch (Console.ReadLine())
{
    case "собака":
        {
            Pet.Type = "собака";
            break;
        }
    case "рыбка":
        {
            Pet.Type = "рыбка";
            break;
        }
    case "хомячок":
        {
            Pet.Type = "хомячок";
            break;
        }
    default:
        {
            Pet.Type = "Неизвестный нам тип";
            break;
        }
}

Console.Write("Введите возраст вашего питомца: ");
Pet.Age = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Имя питомца - {0}", Pet.Name);
Console.WriteLine("Тип питомца - {0}", Pet.Type);
Console.WriteLine("Возраст питомца - {0}", Pet.Age);
Console.WriteLine("Длина имени питомца - {0}", Pet.NameCount);