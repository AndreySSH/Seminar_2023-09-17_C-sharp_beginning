// 4. Напишите программу, которая принимает на вход три
// числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a, b, c, max;

Console.Write("Input first number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
c = Convert.ToInt32(Console.ReadLine());

max = a;
if(b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"{a}, {b}, {c} -> {max}");