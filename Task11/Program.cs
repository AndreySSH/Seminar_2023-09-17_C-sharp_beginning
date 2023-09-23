// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int ReduceNumber3to2(int number)
{
    int thirdDigit = number / 100;
    int firstDigit = number % 10;
    return 10 * thirdDigit + firstDigit;
}

int randNumber = new Random().Next(100, 1000);
int reducedNumber = ReduceNumber3to2(randNumber);
Console.WriteLine($"{randNumber} -> {reducedNumber}");