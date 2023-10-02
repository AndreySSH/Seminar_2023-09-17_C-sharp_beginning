// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumberDigits(int num)
{
    int result = 0;
    while(num != 0)
    {
        int temp = num % 10;
        result += temp;
        num /= 10;
    }
    return result;
}

int number = Prompt("Input number: ");
if(number < 0)
    number *= -1;

int result = SumOfNumberDigits(number);
Console.WriteLine($"{number} -> {result}");
