// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SquareTable(int n)
{
    Console.Write($"{n} - > ");
    for(int count = 1;count < n+1;count++)
    {
        Console.Write($"{count * count, 3},");
    }
    Console.Write("\b  \b");
}

int number = Prompt("Input N: ");

SquareTable(number);