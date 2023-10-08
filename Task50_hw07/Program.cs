// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;

public class Answer {
    const int ROW = 0;
    const int COLUMN = 1;
  
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
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
      int[,] matrix = new int[n, m];
      int value = 1;
      for(int i = 0; i < n; i++)
        for(int j = 0; j < m; j++)
        {
          matrix[i, j] = value;
          value += k;
        }
      return matrix;
    }
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже
      if(rowPosition > matrix.GetLength(ROW) || columnPosition > matrix.GetLength(COLUMN))
        return new int[]{0};
      else
        return new int[]{matrix[rowPosition - 1, columnPosition - 1], 0};
    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
      if(results.Length == 1 && results[0] == 0)
        Console.WriteLine("There is no such index");
      else if (results[1] == 0)
        Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");       
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}