﻿/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет*/

Console.WriteLine("введи второе число ");
Console.WriteLine("введи второе число ");

int a = Convert.ToInt32(Console.ReadLine ());
int b = Convert.ToInt32(Console.ReadLine ());
int sqrB = b * b;

if (sqrB == a)
{
    Console.WriteLine($" да, второе число {b} это квадрат первого числа {a}");
}
else
{
    Console.WriteLine("нет");
}
