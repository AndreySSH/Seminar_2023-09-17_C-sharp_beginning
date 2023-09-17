// 1. Принять число на вход
// 2. Вычислить его квадрат
// 3. Вывести результат
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;

//Console.WriteLine(number + " -> " + square);
Console.WriteLine($"{number} -> {square}");
