// Напишите программу, которая по номеру дня недели
// печатает его название
//1 -> понедельник

Console.Write("Input integer: ");
int num = Convert.ToInt32(Console.ReadLine());
string day;
if(num == 1) day = "понедельник";
else if(num == 2) day = "вторник";
else if(num == 3) day = "среда";
else if(num == 4) day = "четверг";
else if(num == 5) day = "пятница";
else if(num == 6) day = "суббота";
else if(num == 7) day = "воскресенье";
else day = "нет такого дня недели";

Console.Write($"{num} -> {day}");