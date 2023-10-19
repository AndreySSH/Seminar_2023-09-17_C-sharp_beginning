// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

using System;

void PrintNaturalNumbersRange(int n, int m)
{
    if(n > m)
    {
        System.Console.Write(n + " ");
        PrintNaturalNumbersRange(n - 1, m);
    }
    else if (n < m)
    {
        System.Console.Write(n + " ");
        PrintNaturalNumbersRange(n + 1, m);
    }
    else
    {
        System.Console.WriteLine(n);
    }
}

System.Console.WriteLine("Input first natural number: ");
int numberN = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second natural number: ");
int numberM = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbersRange(numberN, numberM);