// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// Набор данных Частотный массив
//
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
//
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

    public static int[] Convert2DTo1D(int[,] array)
    {
        int[] result = new int[array.Length];

        for (int i = 0; i < array.GetLongLength(0); i++)
        {
            long k = i * array.GetLongLength(0);
            for (int j = 0; j < array.GetLongLength(1); j++)
                result[k + j] = array[i, j];
        }

        return result;
    }

    private static void PrintFreq(int[] arr)
    {
        int currentItem = arr[0];
        int counter = 1;
        for (int i = 1; i < arr.Length; i++)
        {
            if(arr[i] == currentItem)
                counter++;
            else
            {
                System.Console.WriteLine($"{currentItem} => {counter}");
                counter = 1;
                currentItem = arr[i];
            }
        }
        System.Console.WriteLine($"{currentItem} => {counter}");
    }
    // TODO: добавить метод, который отдает словарь с частотой вхождения элемента в массив

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
        int[,] testArray = Generate2DArray(n, m, min, max, seed);
        PrintArray(testArray);
        System.Console.WriteLine();

        int[] testArray1D = Convert2DTo1D(testArray);
        PrintArray(testArray1D);
        System.Console.WriteLine();

        Array.Sort(testArray1D);
        PrintFreq(testArray1D);
    }
}