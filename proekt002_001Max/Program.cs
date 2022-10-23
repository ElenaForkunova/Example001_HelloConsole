// Найти максимальное из трех чисел
Console.Write("введи число а ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("введи число b ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("введи число c ");
int c = Convert.ToInt32(Console.ReadLine());

//переменная, которая будет хранить итог
int max = a;
if (b > max)
{
    max =b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine($"Максимальное из трех чисел {max}");
Console.ReadKey();
