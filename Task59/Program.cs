// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

internal partial class Program
{
    const int ROW = 0;
    const int COLUMN = 1;
    private static int[,] Generate2DArray(int sizeM, int sizeN, int min, int max, int seed)
    {
        int[,] arr = new int[sizeM, sizeN];
        Random rnd;
        if(seed == 0)
            rnd = new Random();
        else
            rnd = new Random(seed);

        for(int i = 0; i < sizeM; i++)
        {
            for(int j = 0; j < sizeN; j++)
            {
                arr[i, j] = rnd.Next(min, max + 1);
            }
        }
        return arr;
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

    public static void PrintArray (int [] matrix)
    {
        // Введите свое решение ниже
        for(int i = 0; i < matrix.Length; i++)
            Console.Write($"{matrix[i]}\t");

        Console.WriteLine();
    }

    public static int[] GetMinElemIndex(int[,] matrix)
    {
        int rowMinI = 0, colMinI = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(matrix[i, j] <= matrix[rowMinI, colMinI])
                    (rowMinI, colMinI) = (i, j);
            }
        }
        return new int[] { rowMinI, colMinI };
    }

    public static int[,] RemoveRowAndColumn(int[,] matrix, int remRow, int remCol)
    {
        int[,] resultMatrix = new int [matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

        for (int i = 0, m = 0; i < resultMatrix.GetLength(0); i++, m++)
        {
            if(m == remRow) m++;
            for (int j = 0, n = 0; j < resultMatrix.GetLength(1); j++, n++)
            {
                if(n == remCol) n++;
                resultMatrix[i, j] = matrix[m, n];
            }
        }
        return resultMatrix;
    }

    private static void Main(string[] args)
    {
        int n, m, min, max, seed;
        if (args.Length >= 5) {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            min = int.Parse(args[2]);
            max = int.Parse(args[3]);
            seed = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 4;
            min = 0;
            max = 3;
            seed = 0;
        }
        int[,] array = Generate2DArray(n, m, min, max, seed);
        PrintArray(array);
        System.Console.WriteLine();

        int[] coordsMin = GetMinElemIndex(array);
        int[,] newArray = RemoveRowAndColumn(array, coordsMin[0], coordsMin[1]);

        PrintArray(newArray);
        System.Console.WriteLine();
    }
}