// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ConvertDecToBin(int dec)
{
    int index = 1;
    int bin = 0;
    while(dec > 0)
    {
        bin += (dec % 2) * index;
        dec /= 2;
        index *= 10;
    }
    return bin;
}

int ConvertDecToBinRecursion(int dec)
{
    if(dec < 2) return dec;
    else
    {
        return 10 * ConvertDecToBinRecursion(dec / 2) + (dec % 2);
    }
}

int ConvertDecToBinString(int dec)
{
    string result = "";
    while(dec > 0)
    {
        result = (dec % 2) + result;
        dec /= 2;
    }
    return Convert.ToInt32(result);
}

int number = Prompt("Input number: ");
// int number = new Random.Next(0, 127 + 1);

// int result = ConvertDecToBin(number);
// int result = ConvertDecToBinRecursion(number);
int result = ConvertDecToBinString(number);

Console.WriteLine($"{number} -> {result}");
