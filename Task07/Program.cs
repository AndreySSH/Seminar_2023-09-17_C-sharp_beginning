// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Input 3 digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
if (number < 1000 && number > 99)
{
    int lastDigit = number % 10;
    Console.WriteLine($"{number} -> {lastDigit}");
}
else Console.WriteLine("numrer is not 3 digit");
