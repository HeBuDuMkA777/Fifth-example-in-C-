using System;
using static System.Console;

Clear();

int sizeArray = 10; // Размер массивав
int leftRange = -999; //начальная граница массива
int rightRange = 999; // конечная граница массива
int[] myArray = GetArray(sizeArray, leftRange, rightRange);
WriteLine($"[{String.Join(",", myArray)}]"); //напечатать массив
WriteLine($" Разница между максимальным и минимальным значениями массива равна --> {difference(myArray, leftRange, rightRange)}");


int[] GetArray(int size, int min, int max)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
return result;
}

int difference(int[] Array, int min, int max)
{
    int result = 0;
    int Maximum = min;
    int Minimum = max;
    foreach (var item in Array)
    {
        if (item > Maximum) Maximum = item;
        if (item < Minimum) Minimum = item;
    }
    result = Math.Abs(Maximum - Minimum);
    return result;
}