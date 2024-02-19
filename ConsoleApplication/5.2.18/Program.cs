static int[] GetArrayFromConsole(int num = 5)
{
    var result = new int[num];

    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        result[i] = int.Parse(Console.ReadLine());
    }

    return result;
}

static int[] SortArray(int[] array)
{
    int moveVariable;

    for (int j = 0; j < array.Length; j++)
    {
        for (int k = 0; k < array.Length; k++)
        {
            if (array[j] < array[k])
            {
                moveVariable = array[k];
                array[k] = array[j];
                array[j] = moveVariable;
            }
        }
    }

    return array;
}

static void ShowArray(int[] array, bool sortArray = false)
{
    if (sortArray)
    {
        array = SortArray(array);

        Console.WriteLine("Отсортированный массив:");
        foreach (int number in array)
            Console.Write(number);
    }
    else
    {
        Console.WriteLine("Неотсортированный массив:");
        foreach (int number in array)
            Console.Write(number);
    }
}

int[] array;

array = GetArrayFromConsole(10);

ShowArray(array, true);