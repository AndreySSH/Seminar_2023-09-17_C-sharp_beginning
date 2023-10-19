// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

using System;

int PowRecursive(int a, int b) // (3,5) (3,4) (3,3) (3,2) (3,1) (3,0)
{
    if(b == 0) return 1; // <
    return a * PowRecursive(a, b - 1); // (3,5) (3,4) (3,3) (3,2) (3,1)
    // 3 * 3 * 3 * 3 * 3 * 1 = 243
}

System.Console.WriteLine("Input natural number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input natural number A: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = PowRecursive(numberA, numberB);
System.Console.WriteLine($"{numberA}^{numberB} -> {result}");