// 6. Напишите программу, которая на вход принимает
// число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"{number} -> ");

if(number % 2 == 0) Console.Write("yes");
else Console.Write("no");