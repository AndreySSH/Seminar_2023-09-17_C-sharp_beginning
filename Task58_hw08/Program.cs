// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

using System;
using static MatrixOperations;

public static class MatrixOperations
{
    public const int ROW = 0;
    public const int COL = 1;
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
      if(matrixA.GetLength(COL) != matrixB.GetLength(ROW))
        Console.WriteLine("It is impossible to multiply.");
      else
      {
        int[,] matrixMul = MatrixMultiplication(matrixA, matrixB);
        PrintMatrix(matrixMul);
      }
    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  // Введите свое решение ниже
      int resultRows = matrixA.GetLength(ROW);
      int resultCols = matrixB.GetLength(COL);
      int vectorLength = matrixA.GetLength(COL);
      
      int[,] result = new int[resultRows, resultCols];

      for(int row = 0; row < resultRows; row++)
        for(int col = 0; col < resultCols; col++)
          for(int i = 0; i < vectorLength; i++)
            result[row, col] += matrixA[row,i] * matrixB[i,col];
      
      return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {  // Введите свое решение ниже
      for(int row = 0; row < matrix.GetLength(ROW); row++)
      {
        for(int col = 0; col < matrix.GetLength(COL); col++)
          Console.Write($"{matrix[row, col]}\t");
        Console.WriteLine();
      }
    }
}


public class Answer
{
 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
//                 {5, 2},
//                 {8, 1}
                {1, 2},
                {3, 4}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}