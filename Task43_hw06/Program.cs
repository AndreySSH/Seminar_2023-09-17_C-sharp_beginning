// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x +
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -
// > (-0,5; -0,5)

internal partial class Program
{
    const int X = 0;
    const int Y = 1;
    private static int Prompt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    private static bool TwoLinesIntersection(double k1, double k2, 
                                             double b1, double b2,
                                             double[] result)
    {

        if(k1 == k2) return false;
        else
        {
            result[X] = (b2 - b1) / (k1 - k2);  //x cross
            result[Y] = k1 * result[X] + b1;    //y cross

            return true;
        }
    }

    private static void Main(string[] args)
    {
        System.Console.WriteLine("First line equation: y = k1 * x + b1");
        int b1 = Prompt("b1: ");
        int k1 = Prompt("k1: ");
        System.Console.WriteLine("First line equation: y = k2 * x + b2");
        int b2 = Prompt("b2: ");
        int k2 = Prompt("k2: ");

        double[] intersection = new double[2];
        if(TwoLinesIntersection(k1, k2, b1, b2, intersection))
        {
            System.Console.WriteLine($"Intersection point of y = {k1} * x + {b1} and y = {k2} * x + {b2}");
            System.Console.WriteLine($"is ({intersection[X]:F2}; {intersection[Y]:F2})");
        }
        else
            System.Console.WriteLine("Lines don't intersect!");
    }
}