// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

internal class Program
{
    private static void ShowCube(int N)
    {
        for(int temp = 1;temp < N+1;temp++)
        {
            Console.WriteLine($"{temp * temp * temp, 5}");
        }
    }
    private static int Prompt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    private static void Main(string[] args)
    {
        int N = Prompt("Input number: ");
        
        ShowCube(N);
    }
}