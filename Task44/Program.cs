// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr, bool brackets)
{
    if(brackets) Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    if(brackets) Console.Write("]");
}

int[] Fibonacci(int num)
{
    if(num == 1) num = 2;
    int[] result = new int[num];
    result[1] = 1;
    if(num > 2)
    {
        for(int i = 2; i < num; i++)
        {
           result[i] = result[i-2] + result[i-1];
        }
    }
    return result;
}


int number = Prompt("Input number: ");

int[] fib = Fibonacci(number);

Console.Write($"{number} -> ");
PrintArray(fib, brackets: false);
Console.WriteLine();