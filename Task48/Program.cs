// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
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

    private static int[,] Generate2DArrayAmn(int sizeM, int sizeN)
    {
        int[,] arr = new int[sizeM, sizeN];
        
        for(int i = 0; i < sizeM; i++)
        {
            for(int j = 0; j < sizeN; j++)
            {
                arr[i, j] = i + j;
            }
        }
        return arr;
    }
    private static void Main(string[] args)
    {
        int m = Prompt("Input rows number m: ");
        int n = Prompt("Input columns number n: ");

        int[,] array = Generate2DArrayAmn(m, n);
        
        Print2DArray(array, brackets: true);
    }
    
}