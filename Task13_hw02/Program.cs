// 13. Напишите программу, которая выводит
// третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadConsoleInt(string prompt)
{
    Console.Write(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadConsoleInt("Input number: ");

int digitCount = 1;
int temp = number / 10;
while(temp > 0)
{
    temp /= 10;
    digitCount++;
}

if(digitCount < 3)
{
    Console.WriteLine($"{number} -> third digit is missing");
    return;
}
else
{
    int count = 0;
    temp = number;
    while(count < digitCount - 3)
    {
        temp /= 10;
        count++;
    }
    temp %= 10;
    Console.WriteLine($"{number} -> {temp}");
}