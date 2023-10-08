// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
internal class Program
{
    private static int Prompt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
    private static void Print2DArray(int[,] arr, bool brackets)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            if(brackets) Console.Write("[");
            for(int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                Console.Write($"{arr[i, j]}, ");
            }
            Console.Write($"{arr[i, arr.GetLength(1) - 1]}");
            if(brackets) Console.Write("]");
            Console.WriteLine();
        }
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
    private static void Main(string[] args)
    {
        int m = Prompt("Input rows number m: ");
        int n = Prompt("Input columns number n: ");

        int[,] array = Generate2DArray(0, 99, m, n);
        
        Print2DArray(array, brackets: true);
        // Console.Write(" -> ");
        // PrintArray(array2, brackets: true);
        // Console.WriteLine();

    }
    
}