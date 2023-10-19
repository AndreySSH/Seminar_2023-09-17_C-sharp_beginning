// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int CalcAkkermanFunc(int m, int n)
{
    if(m == 0)       return n + 1;
    else if (n == 0) return CalcAkkermanFunc(m - 1, 1);
    return CalcAkkermanFunc(m - 1, CalcAkkermanFunc(m, n - 1));
}

Console.Write("Input first natural number: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second natural number: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = CalcAkkermanFunc(numberM, numberN);

Console.WriteLine($"m = {numberM}; n = {numberN} -> A(m, n) = {result}");
