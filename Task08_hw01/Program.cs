// 8. Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int N;

Console.Write("Input number N: ");
N = Convert.ToInt32(Console.ReadLine());

if(N == 0) return;

Console.Write($"{N} -> ");

int counter = 1;
while(counter < N + 1)
{
    if(counter % 2 == 0) Console.Write($"{counter}, ");
    counter++;
}

Console.WriteLine("\b\b  ");