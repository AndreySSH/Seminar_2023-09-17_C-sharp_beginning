// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int MaxDigit(int number)
{
    int first_digit = number / 10;
    int second_digit = number % 10;
    return (first_digit > second_digit) ? first_digit : second_digit;
}

const int MIN=10;
const int MAX=99;

int randNum = new Random().Next(MIN, MAX+1);
Console.WriteLine($"Random number from [{MIN},{MAX+1}] -> {randNum}");

// int first_digit = rand_num / 10;
// int second_digit = rand_num % 10;

// if(first_digit > second_digit) Console.WriteLine($"Max digit of number -> {first_digit}");
// else Console.WriteLine($"Max digit of number -> {second_digit}");

// int max_digit = (first_digit > second_digit) ? first_digit : second_digit;
// Console.WriteLine($"Max digit of number -> {max_digit}");

int maxNumber = MaxDigit(randNum);
Console.WriteLine($"Max digit of number -> {maxNumber}");