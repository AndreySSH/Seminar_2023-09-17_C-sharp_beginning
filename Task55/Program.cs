// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

    public static void SwapColumnsAndRows(int[,] array)
    {
        for (int i = 0; i < array.GetLongLength(0) - 1; i++)
            for (int j = i + 1; j < array.GetLongLength(0); j++)
                (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
    }

    private static void Main(string[] args)
    {
        int n, m, k;
        if (args.Length >= 3) {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 4;
            k = 3;
        }
        int[,] testArray = CreateIncreasingMatrix(n, m, k);
        PrintArray(testArray);
        System.Console.WriteLine();

        if(testArray.GetLongLength(0) != testArray.GetLongLength(1))
        {
            SwapColumnsAndRows(testArray);
            PrintArray(testArray);
        }
            
        else
            System.Console.WriteLine("matrix is not square");

    }
}