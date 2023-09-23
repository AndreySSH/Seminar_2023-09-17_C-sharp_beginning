// 12. Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int ReminderNumber(int num1, int num2)
{
    return num1 % num2;
}

Console.WriteLine("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int reminder = ReminderNumber(firstNumber, secondNumber);

if(reminder == 0) Console.WriteLine($"{firstNumber}, {secondNumber} -> is multiple");
else Console.WriteLine($"{firstNumber}, {secondNumber} -> is not multiple, reminder {reminder}");
