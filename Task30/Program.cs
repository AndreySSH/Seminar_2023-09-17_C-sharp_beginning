// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] RandomArray(int min, int max, int length)
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

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int[] arr = RandomArray(0, 1, 8);
PrintArray(arr);
