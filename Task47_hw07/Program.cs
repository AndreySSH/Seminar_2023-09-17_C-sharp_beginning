// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

internal partial class Program
{
    private static int Prompt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static double[,] CreateRandomMatrix(int m, int n,
                                               int minLimitRandom,
                                               int maxLimitRandom)
    {
        double[,] arr = new double[m, n];
        Random rnd = new Random();

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                arr[i, j] = rnd.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom;
            
        return arr;


    }

    public static void Print2DArrayDouble(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                Console.Write($"{matrix[i, j]:F2}\t");
            
            Console.WriteLine($"{matrix[i, matrix.GetLength(1) - 1]:F2}");
        }
    }
    private static void Main(string[] args)
    {
        int m = Prompt("Input rows number m: ");
        int n = Prompt("Input columns number n: ");

        double[,] array = CreateRandomMatrix(m, n, -10, 10);
        
        Print2DArrayDouble(array);
    }
}