//пока нерабочая сортировка
int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
{
    int swapVariable;

    for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
    {
        for (int k = 1; k < arr.GetUpperBound(1) + 1; k++)

            if (arr[i,k] < arr[i+1,k])
        {
            swapVariable = arr[i+1,k];
            arr[i+1,k] = arr[i,k];
            arr[i,k] = swapVariable;
        }

    }
}

foreach (var number in arr)
{
    Console.Write(number);
}