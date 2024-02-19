//все массивы одинаковы, переделать
int[] array, sortedDesc, sortedAsc;

array = GetArrayFromConsole();
sortedDesc = sortedAsc = array;

ShowArray(array, sortedDesc, sortedAsc);


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

static void SortArray(in int[] array, out int[] sortedDesc, out int[] sortedAsc)
{
    sortedDesc = SortArrayDesc(array);
    sortedAsc = SortArrayAsc(array);
}

static int[] SortArrayDesc(int[] descArray)
{
    int moveVariable;

    for (int j = 0; j < descArray.Length; j++)
    {
        for (int k = 0; k < descArray.Length; k++)
        {
            if (descArray[j] > descArray[k])
            {
                moveVariable = descArray[k];
                descArray[k] = descArray[j];
                descArray[j] = moveVariable;
            }
        }
    }

    return descArray;
}

static int[] SortArrayAsc(int[] ascArray)
{
    int moveVariable;

    for (int j = 0; j < ascArray.Length; j++)
    {
        for (int k = 0; k < ascArray.Length; k++)
        {
            if (ascArray[j] < ascArray[k])
            {
                moveVariable = ascArray[k];
                ascArray[k] = ascArray[j];
                ascArray[j] = moveVariable;
            }
        }
    }

    return ascArray;
}

static void ShowArray(int[] array, int[] sortedDesc, int[] sortedAsc)
{
    SortArray(array, out sortedDesc, out sortedAsc);

    Console.WriteLine("Первичный массив:");
    foreach (int number in array)
        Console.Write(number + " ");

    Console.WriteLine();

    Console.WriteLine("Отсортированный массив от большего к меньшему:");
    foreach (int number in sortedDesc)
        Console.Write(number+" ");

    Console.WriteLine();

    Console.WriteLine("Отсортированный массив от меньшего к большему:");
    foreach (int number in sortedAsc)
        Console.Write(number + " ");
}
