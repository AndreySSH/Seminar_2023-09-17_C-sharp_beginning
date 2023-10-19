// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

using System;

int PrintSumOfNumberDigits(int num) // 453 45 4 0
{
    if(num == 0) return 0;
    return num % 10 + PrintSumOfNumberDigits(num / 10); // 453 45 4
    // 4%10 + 45%10 + 453%10 + 0 = 12
}

System.Console.WriteLine("Input natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = PrintSumOfNumberDigits(number);
System.Console.WriteLine($"{number} -> {result}");