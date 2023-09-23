// 10. Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(99 < number && number < 1000)
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine($"{number} -> {secondDigit}");
}
else Console.WriteLine("Input number is not three digit.");