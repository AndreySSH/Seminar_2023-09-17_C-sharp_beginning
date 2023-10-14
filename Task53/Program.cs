// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

internal partial class Program
{
    const int ROW = 0;
    const int COLUMN = 1;
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] matrix = new int[n, m];
        int value = 1;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = value;
                value += k;
            }
        return matrix;
    }

    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
      for(int i = 0; i < matrix.GetLength(ROW); i++)
      {
        for(int j = 0; j < matrix.GetLength(COLUMN); j++)
          Console.Write($"{matrix[i, j]}\t");

        Console.WriteLine();
      }
    }

    public static bool SwapRows(int[,] array, int row1, int row2)
    {
        if(row1 > array.GetLongLength(0) - 1 || row2 > array.GetLongLength(0) - 1)
            return false;
        else
        {
            for (int i = 0; i < array.GetLongLength(1); i++)
                (array[row1, i], array[row2, i]) = (array[row2, i], array[row1, i]);
        }
        return true;
    }

    private static void Main(string[] args)
    {
        int n, m, swap1, swap2;
        if (args.Length >= 3) {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            swap1 = int.Parse(args[2]);
            swap2 = int.Parse(args[3]);

        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 3;
            swap1 = 0;
            swap2 = n - 1;
        }
        int[,] testArray = CreateIncreasingMatrix(n, m, k: 3);
        PrintArray(testArray);
        System.Console.WriteLine();

        if(SwapRows(testArray, swap1, swap2))
            PrintArray(testArray);
        else
            System.Console.WriteLine("rows out of array index!");

    }
}