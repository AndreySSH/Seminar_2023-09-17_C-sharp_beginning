// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ArithmeticProgressionRec(int num)
{
    if(num < 2)
        return num;
    else
        return ArithmeticProgressionRec(num - 1) + num;
}

int ArithmeticProgression(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        checked
        {
            sum += i;
        }
    }
    return sum;
}

int number = Prompt("Input integer and positive number: ");

if(number < 1)
{
    Console.WriteLine($"{number} is not positive");
    return;
}
// int sumOfNumbers = ArithmeticProgressionRec(number);
int sumOfNumbers = ArithmeticProgression(number);

Console.WriteLine($"Sum of numbers between 1 and {number} = {sumOfNumbers}");