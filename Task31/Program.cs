// Задача 31:
// 1. Задайте массив из 12 элементов,
// 2. заполненный случайными числами из промежутка [-9, 9].
// 3. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] GenerateArray(int min, int max, int size)
{
    int[] arr = new int[size];
    var rnd = new Random();

    for(int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    //Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    //Console.Write("]");
}

int[] GetSum(int[] arr)
{
    int sumPositive = 0, sumNegative = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            sumPositive += arr[i];
        else
            sumNegative += arr[i];
    }
    return new int[] {sumPositive, sumNegative};
}

int GetSumPositive(int[] arr)
{
    int sumPositive = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            sumPositive += arr[i];
    }
    return sumPositive;
}

int GetSumNegative(int[] arr)
{
    int sumNegative = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
            sumNegative += arr[i];
    }
    return sumNegative;
}



int[] array = GenerateArray(-9, 9, 12);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int[] sum = GetSum(array);

Console.WriteLine($"sum positive  ->  {sum[0]}");
Console.WriteLine($"sum negative -> {sum[1]}");

int sumPositiveEl = GetSumPositive(array);
int sumNegativeEl = GetSumNegative(array);

Console.WriteLine($"sum positive  ->  {sumPositiveEl}");
Console.WriteLine($"sum negative -> {sumNegativeEl}");