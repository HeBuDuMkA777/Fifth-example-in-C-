using System;
using static System.Console;

Clear();

WriteLine("Введите размер массива: ");
int sizeArray = int.Parse(ReadLine());
int[] myArray = GetArray(sizeArray, 100, 999);
// WriteLine($"[{String.Join(",", myArray)}]"); напечатать массив
WriteLine($"Количество четных символов в массиве - {GetCountEven(myArray)}");


int[] GetArray(int size, int min, int max)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
return result;
}

int GetCountEven(int[] Array)
{
    int count = 0;
    foreach (var item in Array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}