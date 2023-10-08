// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

internal partial class Program
{
    private static int[] PromptMulti()
    {
        Console.WriteLine("Input multiple numbers");
        string[] numbersString = Console.ReadLine().Split(',',' ');
        int[] numbers = new int[numbersString.Length];

        for (int i = 0; i < numbersString.Length; i++)
            numbers[i] = Convert.ToInt32(numbersString[i]);

        return numbers;
    }

    private static int CalcPositives(int[] arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
            if(arr[i] > 0)
                result++;

        return result;
    }
    private static void Main(string[] args)
    {
        int[] array = PromptMulti();
        System.Console.WriteLine($"Numbers > 0  ==>>  {CalcPositives(array)}");
    }
}