// Напишите программу, которая принимает на вход координаты точки 
//(X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка

//получить номер четверти на плоскости
int GetPointArea (int coordX, int coordY)
{
    int numberArea = 0;
    if (coordX > 0 && coordY> 0)
    {
        numberArea = 1;
    }
    if (coordX < 0 && coordY > 0)
    {
        numberArea = 2;
    }
    if (coordX < 0 && coordY < 0)
    {
        numberArea = 3;
    }
     if (coordX > 0 && coordY < 0)
    {
        numberArea = 4;
    }
    return numberArea;
}
//<возращаемый тип данных> <наиманование метода> (переменные) {тело метода}
Console.WriteLine("введи х:");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введи y:");
int Y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(X, Y);
Console.WriteLine(numberArea);
