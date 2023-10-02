// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfArrayEvenOddNumbers(int[] array, bool even = true)
{
    int result = 0;

    int remainder;
    if(even) remainder = 0;
    else     remainder = 1;
    
    for(int i = 0; i < array.Length; i++)
        if(i % 2 == remainder) result += array[i];

    return result;
}

// odd - нечет
// even - чет

int size = Prompt("Input array size: ");
if(size < 1)
{
    Console.WriteLine("Array size must be > 0!");
    return;
}

int[] array = GenerateRandomArrayInt(-10, 10, size);

// int sumEven = SumOfArrayEvenOddNumbers(array);
int sumOdd = SumOfArrayEvenOddNumbers(array, even: false);

PrintArray(array, brackets: true);
Console.WriteLine($" sum of odd(нечетных) indexes elements -> {sumOdd}");
// Console.WriteLine($" sum of even(четных) indexes -> {sumEven}, sum of odd(нечетных) indexes -> {sumOdd}");