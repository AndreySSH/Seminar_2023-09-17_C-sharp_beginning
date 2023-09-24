// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> False
// 23432 -> True
// 12821 -> True
// 234322 -> Число не пятизначное
// False

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsPalindrome(int number)
{
    if (number > 99999 || number < 10000)
    {
        Console.WriteLine("Число не пятизначное");
        return false;
    }

    //мое решение в лоб    
    /*
    int[] digits = new int[5];
    digits[0] = number / 10000;
    digits[1] = (number / 1000) % 10;
    digits[2] = (number / 100) % 10;
    digits[3] = (number / 10) % 10;
    digits[4] = number % 10;
    if (digits[0] == digits[4] && digits[1] == digits[3])  return true;
    else return false;
    */

    //"красивое" математическое решение
    int numberReverse = 0;
    int temp = number;
    while(temp > 0)
    {
        numberReverse = numberReverse * 10 + temp % 10;
        temp /= 10;
    }
    return numberReverse == number;
}

int number = Prompt("Input number: ");

Console.Write($"{number} -> ");
Console.WriteLine($"{IsPalindrome(number)}");