﻿var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
int result = 0;

for (int i = 0; i < arr.Length; i++)
{
    result += arr[i];
}

Console.WriteLine(result);