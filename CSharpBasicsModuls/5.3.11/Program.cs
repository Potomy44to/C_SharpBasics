static int SumNumbers(ref int num1, in int num2, out int num3, int num4)
{
    num1 = 5;
    num3 = num1 + num2;

    return num3 * num4;
}

int num1 = 1, num2 = 2, num3, num4 = 4;

var result = SumNumbers(ref num1, num2, out num3, num4);

Console.WriteLine(result);