// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

internal class Program
{
    private static int Prompt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    private static int[,] Generate2DArray(int min, int max, int sizeM, int sizeN)
    {
        int[,] arr = new int[sizeM, sizeN];
        var rnd = new Random();

        for(int i = 0; i < sizeM; i++)
        {
            for(int j = 0; j < sizeN; j++)
            {
                arr[i, j] = rnd.Next(min, max + 1);
            }
        }
        return arr;
    }
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

    private static int SumOfDiagElements(int[,] arr)
    {
        int minDim = arr.GetLength(0) < arr.GetLength(1)
                   ? arr.GetLength(0)
                   : arr.GetLength(1);
        int sum = 0;
        
        for (int i = 0; i < minDim; i++)
            sum += arr[i, i];
        
        return sum;
    }

    private static void Main(string[] args)
    {
        int m = Prompt("Input rows number m: ");
        int n = Prompt("Input columns number n: ");

        int[,] array = Generate2DArray(0, 10, m, n);

        Console.WriteLine("Array:");
        Print2DArray(array, brackets: true);

        int sumDiag = SumOfDiagElements(array);
        Console.WriteLine($"Summ of main diag elements = {sumDiag}");
    }

}