/* 14. Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да*/

Console.Write("введи число а ");
double a = Convert.ToInt32(Console.ReadLine());

//проверякем кратность
if ( a % 7 == 0 && a % 23 == 0)
    {
        Console.WriteLine("да");
    }
else
    {
        Console.WriteLine("нет");
    }
