using System;
using static System.Console;

Clear();

int[] myArray = GetArray(10, -999, 999);
WriteLine($"[{String.Join(",", myArray)}]"); //напечатать массив
WriteLine($" Сумма чисел на четных позициях равна --> {GetSumEven(myArray)}");


int[] GetArray(int size, int min, int max)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
return result;
}

int GetSumEven(int[] Array)
{
    int result = 0;
    for (int i = 1; i < Array.Length; i += 2)
    {
        result += Array[i];
    }
    return result;
}
