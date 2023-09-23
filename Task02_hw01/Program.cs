// 2. Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее,
// а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a, b, max;

Console.Write("Input first number a = ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first number b = ");
b = Convert.ToInt32(Console.ReadLine());

if(a > b) max = a;
else max = b;

Console.WriteLine($"a = {a}; b = {b} -> max = {max}");