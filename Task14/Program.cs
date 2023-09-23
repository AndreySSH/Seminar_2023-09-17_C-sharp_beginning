// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool IsMultipleTwoNumbers(int num, int div1, int div2)
{
    return (num % div1 == 0) && (num % div2 == 0);
}

Console.Write("Input number:");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsMultipleTwoNumbers(number, 7, 23);

Console.WriteLine(result ? $"{number} -> yes" : $"{number} -> no");