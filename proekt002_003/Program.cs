/* 11. Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/

//случайное число, при этом 1000 - не входит
int number = new Random().Next(100,1000);
Console.WriteLine($"случайное число от 100 до 999 равно {number}");

int a1 = number/100;
int a2 = (number % 10);
int result = a1 *10 + a2;

Console.WriteLine($"трехзначное число с удаленной второй цифрой {result}");