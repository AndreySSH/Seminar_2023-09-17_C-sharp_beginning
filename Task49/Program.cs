// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

internal class Program
{
    private static void Print2DArray(int[,] arr, bool brackets)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (brackets) Console.Write("[");
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                Console.Write($"{arr[i, j]}, ");
            }
            Console.Write($"{arr[i, arr.GetLength(1) - 1]}");
            if (brackets) Console.Write("]");
            Console.WriteLine();
        }
    }

    private static void ArrayReplaceBothEvenIndToSquare(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
                    arr[i, j] = arr[i, j] * arr[i, j];
            }
        }
    }

    private static void Main(string[] args)
    {
        int[,] array = new int[,]
        {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
        };
        Console.WriteLine("Original array:");
        Print2DArray(array, brackets: true);

        ArrayReplaceBothEvenIndToSquare(array);
        Console.WriteLine("Array after replacing all elements with both even indexes to squares:");
        Print2DArray(array, brackets: true);
    }

}