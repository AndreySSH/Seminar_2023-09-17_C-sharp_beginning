// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Input integer a=");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer b=");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("нет");
Console.Write($"a={a}, b={b} -> ");
if(a == b * b) Console.WriteLine("да");
else Console.WriteLine("нет");
