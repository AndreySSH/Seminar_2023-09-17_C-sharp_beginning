// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenerateRandomArrayInt(int min, int max, int size)
{
    int[] result = new int[8];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
        result[i] = rnd.Next(min, max + 1);

    return result;
}

void PrintArray(int[] array, bool brackets)
{
    if(brackets) Console.Write("[");
    
    for(int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    
    Console.Write($"{array[array.Length - 1]}");
    if(brackets) Console.Write("]");
}

int[] array = GenerateRandomArrayInt(1, 100, 8);
PrintArray(array, false);
Console.Write(" -> ");
PrintArray(array, true);
Console.WriteLine();