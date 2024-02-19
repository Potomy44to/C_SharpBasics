static void GetName(ref string name)
{
    Console.WriteLine("Введите имя");
    name = Console.ReadLine();

}

var someOne = "Евгения";
Console.WriteLine(someOne);

GetName(ref someOne);
Console.WriteLine(someOne);