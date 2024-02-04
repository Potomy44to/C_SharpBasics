Console.WriteLine("What is your name? ");
var name = Console.ReadLine();

Console.WriteLine("What is your age? ");
var age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your name is {0} and age is {1}", name, age);

Console.WriteLine("What is your date of birth? ");
var birthDate = Console.ReadLine();

Console.WriteLine("Your birthdate is {0}", birthDate);

enum daysOfWeek : byte
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

