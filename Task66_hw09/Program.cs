// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintSumOfNaturalNumbersRange(int m, int n)
{
    if(m < n)       return n + PrintSumOfNaturalNumbersRange(m, n - 1);
    else if (m > n) return n + PrintSumOfNaturalNumbersRange(m, n + 1);
    else            return n;
}

Console.Write("Input first natural number: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second natural number: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = PrintSumOfNaturalNumbersRange(numberN, numberM);

Console.WriteLine($"M = {numberM}; N = {numberN} -> {result}");
