// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое
// каждого столбца: 4,6; 5,6; 3,6; 3

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
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
      Console.WriteLine("The averages in columns are: ");
      for(int i = 0; i < list.Length; i++)
        Console.Write($"{list[i]:F2}\t");

      Console.WriteLine();
    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
      double[] average = new double[matrix.GetLength(COLUMN)];
      for(int j = 0; j < matrix.GetLength(COLUMN); j++)
      {
        for(int i = 0; i < matrix.GetLength(ROW); i++)
          average[j] += matrix[i, j];
         
         average[j] /= matrix.GetLength(ROW);
      }
      return average;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}