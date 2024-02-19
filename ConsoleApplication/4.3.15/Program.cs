int[] arr = {1, 0, -8, -3, 7};
int positiveNumbers = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        positiveNumbers += 1;
    }
}

Console.WriteLine(positiveNumbers);