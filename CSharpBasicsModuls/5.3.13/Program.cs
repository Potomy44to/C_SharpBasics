//все массивы одинаковы, переделать
int[] array, sortedDesc, sortedAsc;

array = GetArrayFromConsole();
SortArray(in array, out sortedDesc, out sortedAsc);

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
    int[] copyArray = new int[array.Length];
    Array.Copy(array, copyArray, array.Length);

    sortedAsc = SortArrayAsc(copyArray);
    sortedDesc = SortArrayDesc(copyArray);
}

static int[] SortArrayDesc(int[] descArray)
{
    int[] copyDescArray = new int[descArray.Length];
    Array.Copy(descArray, copyDescArray, descArray.Length);

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

    return copyDescArray;
}

static int[] SortArrayAsc(int[] ascArray)
{
    int[] copyAscArray = new int[ascArray.Length];
    Array.Copy(ascArray, copyAscArray, ascArray.Length);

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

    return copyAscArray;
}

static void ShowArray(int[] array, int[] sortedDesc, int[] sortedAsc)
{
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
