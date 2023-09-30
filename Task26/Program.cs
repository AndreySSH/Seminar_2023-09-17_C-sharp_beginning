// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CalcNUmberOfDigits(int num)
{
    if(num == 0)
        return 1;

    int counter = 0;
    while(num != 0)
    {
        counter++;
        num /= 10;
    }
    return counter;
}

int number = Prompt("Input number: ");
int numberOfDigits = CalcNUmberOfDigits(number);
Console.WriteLine($"Number of digits in {number} -> {numberOfDigits}");