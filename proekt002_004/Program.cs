/* 2. Напишите программу, которая будет принимать 
на вход два числа и выводить, является ли второе число 
кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/

Console.Write("введи число а ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("введи число b ");
double b = Convert.ToInt32(Console.ReadLine());

//ищем остаток
double AB1 = a % b;

//ищем кратность
double AB2 = a / b;
if ( a > b )
{
    if (a % b == 0)
    {
        Console.WriteLine($"первое число разделить на второе равно {AB2}");
    }
    else
    {
        Console.WriteLine($"Число не кратно,остаток {AB1}");
    }
}
else
{
    Console.WriteLine("Первое число содержит 0 вторых");
}
Console.ReadKey();