// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Input integer: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0) number = -number;

Console.Write($"{number} -> \"");
for(int count=-number;count<number;count++){
    Console.Write($"{count}, ");
}
Console.WriteLine($"{number}\"");