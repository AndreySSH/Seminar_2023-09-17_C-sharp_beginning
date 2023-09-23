// 15. Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadConsoleInt(string prompt)
{
    Console.Write(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsDayOfWeek(int num)
{
    if(num > 0 && num < 8) return true;
    else return false;
}

bool IsWeekend(int num)
{
    if(num > 5) return true;
    else return false;
}

int number = ReadConsoleInt("Input day of week number: ");

if(IsDayOfWeek(number)) 
{
    Console.WriteLine($"{number} -> " + (IsWeekend(number) ? "yes" : "no"));
}
else Console.WriteLine("It is not day of week!");