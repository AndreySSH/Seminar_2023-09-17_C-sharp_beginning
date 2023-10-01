// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

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

void PrintArray(int[] arr, bool brackets)
{
    if(brackets) Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    if(brackets) Console.Write("]");
}

int[] ArrayProdBeginToEnd(int[] arr)
{
    int sizeNewArr = arr.Length / 2 + arr.Length % 2;
    int[] arrNew = new int[sizeNewArr];
    
    for(int i = 0; i < sizeNewArr; i++)
    {
        arrNew[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if(arr.Length % 2 == 1) arrNew[sizeNewArr - 1] = arr[sizeNewArr - 1];
    return arrNew;
}

int[] array1 = GenerateArray(0, 10, 7);
int[] arrayNew1 = ArrayProdBeginToEnd(array1);

int[] array2 = GenerateArray(0, 10, 6);
int[] arrayNew2 = ArrayProdBeginToEnd(array2);

PrintArray(array1, true);
Console.Write($" -> ");
PrintArray(arrayNew1, false);
Console.WriteLine();

PrintArray(array2, true);
Console.Write($" -> ");
PrintArray(arrayNew2, false);
Console.WriteLine();