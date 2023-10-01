// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GenerateArray(int min, int max, int size)
{
    int[] arr = new int[size];
    var rnd = new Random();

    for(int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArrayBr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
}

void InvertArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}



int[] array = GenerateArray(-9, 9, 12);
PrintArrayBr(array);

InvertArray(array);
Console.Write(" -> ");
PrintArrayBr(array);
Console.WriteLine();

