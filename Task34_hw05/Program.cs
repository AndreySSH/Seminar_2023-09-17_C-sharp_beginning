// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateRandomArrayInt(int min, int max, int length)
{
    int[] array = new int[length];
    var rnd = new Random();
    for(int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
        // array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array, bool brackets)
{
    if(brackets) Console.Write("[");
    
    for(int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    
    Console.Write($"{array[array.Length - 1]}");
    if(brackets) Console.Write("]");
}

// odd - нечет
// even - чет

int CountEvenOddNumbersInArray(int[] array, bool even = true)
{
    int result = 0;
    int remainder;
    if(even) remainder = 0;
    else     remainder = 1;
    
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == remainder) result++;

    return result;
}

int size = Prompt("Input array size: ");
if(size < 1)
{
    Console.WriteLine("Array size must be > 0!");
    return;
}

int[] array = GenerateRandomArrayInt(100, 999, size);
int resultEven = CountEvenOddNumbersInArray(array);
int resultOdd = CountEvenOddNumbersInArray(array, even: false);
PrintArray(array, brackets: true);
Console.WriteLine($" even(четных) -> {resultEven}, odd(нечетных) -> {resultOdd}");