// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

void Reverse1DArray(int[] arr)
{
    for(int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
        // (arr[i], arr[arr.Length - 1 - i]) = (arr[arr.Length - 1 - i], arr[i]);
    }
}

int[] array = GenerateArray(1, 9 ,5);
PrintArray(array, brackets: true);
Console.Write($" -> ");
Reverse1DArray(array);
// Array.Reverse(array);
PrintArray(array, brackets: true);