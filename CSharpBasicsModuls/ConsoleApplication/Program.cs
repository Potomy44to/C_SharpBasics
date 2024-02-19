
var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

for (int i = 0; i < arr.Length; i++)
{
    int swapVariable;

    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[i] < arr[k])
        {
            swapVariable = arr[k];
            arr[k] = arr[i];
            arr[i] = swapVariable;
        }

    }
}

foreach (var number in arr)
{
    Console.Write(number);
}

