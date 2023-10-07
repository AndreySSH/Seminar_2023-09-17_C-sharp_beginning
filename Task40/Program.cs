// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsTriangle(int[] sides)
{
    return sides[0] < sides[1] + sides[2] &&
           sides[1] < sides[0] + sides[2] &&
           sides[2] < sides[0] + sides[1];
}

int[] triang = new int[3];
triang[0] = Prompt("Input 1 side of triangle: ");
triang[1] = Prompt("Input 2 side of triangle: ");
triang[2] = Prompt("Input 3 side of triangle: ");

Console.WriteLine(IsTriangle(triang) ? "Triangle is exist." : "Triangle is NOT exist.");