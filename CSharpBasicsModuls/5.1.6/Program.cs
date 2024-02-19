static int[] GetArrayFromConsole()
{
    var result = new int[5];
    int moveVariable;

    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        result[i] = int.Parse(Console.ReadLine());
    }

    for (int j = 0; j < result.Length; j++)
    {
        for (int k = 0; k < result.Length; k++)
        {
            if (result[j] < result[k])
            {
                moveVariable = result[k];
                result[k] = result[j];
                result[j] = moveVariable;
            }
        }
    }

    Console.WriteLine("Отсортированный массив:");
    foreach(int number in result)
        Console.Write(number);

    return result;
}


GetArrayFromConsole();