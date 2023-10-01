// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
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

bool IsNumberInArray(int[] arr, int num)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(num == arr[i]) return true;
    }
    return false;
}

int numberToFind = Prompt("Input number: ");

int[] array = GenerateArray(-9, 9, 12);

bool includes = IsNumberInArray(array, numberToFind);

Console.Write($"{numberToFind}; array ");
PrintArrayBr(array);
Console.WriteLine("-> " + (includes ? "yes" : "no"));