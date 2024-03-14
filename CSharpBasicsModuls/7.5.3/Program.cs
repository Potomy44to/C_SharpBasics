int num1 = 3;
int num2 = 58;

Helper.Swap(ref num1, ref num2);

Console.WriteLine(num1); //58
Console.WriteLine(num2); //3

class Helper
{
    public static void Swap(ref int value1, ref int value2)
    {
        int swapValue = value2;
        value2 = value1;
        value1 = swapValue;
    }
}

