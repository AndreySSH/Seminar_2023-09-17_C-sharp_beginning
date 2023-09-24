// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System.Globalization;
internal class Program
{
    private static double Length(int[] pointA, int[] pointB)
    {
        return Math.Sqrt(
            Math.Pow(pointA[0] - pointB[0], 2) +
            Math.Pow(pointA[1] - pointB[1], 2) +
            Math.Pow(pointA[2] - pointB[2], 2)
            );
    }
    private static int Prompt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    private static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        
        int[] pA = new int[3];
        int[] pB = new int[3];

        pA[0] = Prompt("Input point A x: ");
        pA[1] = Prompt("Input point A y: ");
        pA[2] = Prompt("Input point A z: ");

        pB[0] = Prompt("Input point B x: ");
        pB[1] = Prompt("Input point B y: ");
        pB[2] = Prompt("Input point B z: ");

        //Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        double lenght = Length(pA, pB);
        //double lenghtRound = Math.Round(lenght,2,MidpointRounding.ToZero);
        
        
        Console.WriteLine($"A({pA[0]},{pA[1]},{pA[2]}); B({pB[0]},{pB[1]},{pB[2]}) -> {lenght:F2}");
    }
}