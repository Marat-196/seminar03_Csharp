// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координаты точки x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1, x2, y1, y2);

Console.WriteLine($"{Math.Round(res, 2, MidpointRounding.ToZero)}");

double Distance(int xValue1, int xValue2, int yValue1, int yValue2)
{
    double result = Math.Sqrt(Math.Pow((xValue2 - xValue1), 2) + Math.Pow((yValue2 - yValue1), 2));
    return result;
}
