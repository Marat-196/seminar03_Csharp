// 17. Напишите программу, которая принимает 

// 1. на вход координаты точки (X и Y), 
// 2. причём X ≠ 0 и Y ≠ 0 и 
// 3. выдаёт номер четверти плоскости, в которой находится эта
// точка.


Console.Write("Введите координаты точки Х = ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки Y = ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarted = Quarted(xCoordinate, yCoordinate);

string result = quarted > 0 ? $"Указанные координаты соответствуют четверти {quarted}":"Введены некорректные координаты";

Console.WriteLine(result);

int Quarted(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}