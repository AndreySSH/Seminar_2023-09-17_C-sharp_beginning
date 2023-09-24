// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double VectorLenght(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}

int pAx = Prompt("Input point A x: ");
int pAy = Prompt("Input point A y: ");
int pBx = Prompt("Input point B x: ");
int pBy = Prompt("Input point B y: ");

double lenght = VectorLenght(pAx, pAy, pBx, pBy);
//double lenghtRound = Math.Round(lenght,2,MidpointRounding.ToZero);

Console.WriteLine($"A({pAx}{pAy}); B({pBx}{pBy}) -> {lenght:F2}");