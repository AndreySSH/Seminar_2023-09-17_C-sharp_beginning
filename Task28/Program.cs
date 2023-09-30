// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Fact(int num)
{
    int result = 1;
    for(int i = 1; i <= num; i++)
    {
        checked
        {
            result *= i;
        }
    }
    return result;
}

int number = Prompt("Input integer and positive number: ");

if(number < 1)
{
    Console.WriteLine($"{number} is not positive");
    return;
}

int factOfNumber = Fact(number);

Console.WriteLine($"Factorial of {number} = {factOfNumber}");