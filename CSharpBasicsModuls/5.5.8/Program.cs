Console.WriteLine("Введите число для возведения его в степень:");
int number = Int32.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите степень возведения:");
byte degree = Byte.Parse(Console.ReadLine());

var result = PowerUp(number, degree);

static int PowerUp(int N, byte pow)
{
    if (pow == 0)
    {
        return 1;
    }
    else if (pow == 1)
    {
        return N;
    }
    else
    {
        return N * PowerUp(N, --pow);
    }
}

Console.WriteLine(result);