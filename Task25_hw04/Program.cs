// Задача 25: Напишите цикл, который принимает на вход два
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Pow(int number, int pow)
{
    int result = number;
    for(int i = 1; i < pow; i++)
        result *= number;
    return result;
}

int numberA = Prompt("Input number A: ");
int numberB = Prompt("Input number B: ");
if(numberB < 1)
{
    Console.WriteLine($"{numberB} is not natural number!");
    return;
}

int result = Pow(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {result}");
