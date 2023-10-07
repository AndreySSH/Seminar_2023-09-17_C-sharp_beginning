// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

namespace Task45;
internal class Program
{
    private static int[] CopyArray(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            result[i] = arr[i];

        return result;
    }

    private static void PrintArray(int[] arr, bool brackets)
    {
        if(brackets) Console.Write("[");
        for(int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write($"{arr[i]}, ");
        }
        Console.Write($"{arr[arr.Length - 1]}");
        if(brackets) Console.Write("]");
    }

    private static int[] GenerateArray(int min, int max, int size)
    {
        int[] arr = new int[size];
        var rnd = new Random();

        for(int i = 0; i < size; i++)
        {
            arr[i] = rnd.Next(min, max + 1);
        }
        return arr;
    }
    private static void Main(string[] args)
    {
        int[] array1 = GenerateArray(1, 9, 5);
        int[] array2 = CopyArray(array1);
        array2[0] = 12345;

        PrintArray(array1, brackets: true);
        Console.Write(" -> ");
        PrintArray(array2, brackets: true);
        Console.WriteLine();

    }
}