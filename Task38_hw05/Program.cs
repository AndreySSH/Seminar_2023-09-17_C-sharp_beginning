// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenerateRandomArrayReal(double min, double max, int length)
{
    var array = new double[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
        array[i] = rnd.NextDouble() * (max - min) + min;

    return array;
}

void PrintArrayReal(double[] array, bool brackets = true)
{
    if (brackets) Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]:F1}  ");

    Console.Write($"{array[array.Length - 1]:F1}"); // с русской локалью разделители целой и дробной части запятые :-(
    if (brackets) Console.Write("]");
}

// метод возвращает массив из двух элементов
// [0] - индекс min элемента массива, [1] - индекс max элемента массива
int[] FindMinMaxIndex(double[] array)
{
    int maxI = 0, minI = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[maxI])
            maxI = i;
        if (array[i] < array[minI])
            minI = i;
    }
    return new int[] { minI, maxI };
}

// метод возвращает кортеж с двумя полями, хотя кортежи мы еще не изучали :-)
// minI - индекс min элемента массива, maxI - индекс max элемента массива
(int, int) FindMinMaxIndexTuple(double[] array)
{
    int maxI = 0, minI = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[maxI])
            maxI = i;
        if (array[i] < array[minI])
            minI = i;
    }
    return (minI, maxI);
}


int size = Prompt("Input array size: ");
if (size < 1)
{
    Console.WriteLine("Array size must be > 0!");
    return;
}

double[] array = GenerateRandomArrayReal(0, 10, size);

int[] result = FindMinMaxIndex(array);  // более громоздко
int minI = result[0];
int maxI = result[1];

// (int minI, int maxI) = FindMinMaxIndexTuple(array); // код вызова метода получается нагляднее

double difference = array[maxI] - array[minI];

PrintArrayReal(array);
Console.WriteLine($" => {array[maxI]:F1} - {array[minI]:F1} = {difference:F1}");