// Напишите программу, которая принимает на вход координаты точки 
//(X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка

//получить номер четверти на плоскости

string GetXYArea(int che)
{
    if (che == 1)
    {
        return "X > 0 & Y > 0";
    }
    if (che == 2)
    {
        return "X < 0 & Y > 0";
    }
    if (che == 3) 
    {
        return "X < 0 & Y < 0";
    }
     if (che == 4) 
    {
        return "X > 0 & Y < 0";
    }
    return "четверти нет";
}

//<возращаемый тип данных> <наиманование метода> (переменные) {тело метода}
Console.WriteLine("введи четверть: ");
int che = Convert.ToInt32(Console.ReadLine());

string result = GetXYArea(che);
Console.WriteLine(result);