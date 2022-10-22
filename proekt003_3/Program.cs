/*комментарий, котрый нужно написать на несколько строк 
можно записать так*/

Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты 2 точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1,int x2,int y2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
    return result;
}
double result = Distance(x1, y1, x2, y2);
Console.WriteLine(result);