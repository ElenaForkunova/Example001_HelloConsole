/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/

/*Console.WriteLine("введи число дня недели от 1 до 7 ");
int numberWeek = Convert.ToInt32(Console.ReadLine());
if (numberWeek > 7|| numberWeek < 1)
{
    Console.WriteLine("введи число дня недели от 1 до 7 ");
}
else
{
    if (numberWeek ==1)
   {
    Console.WriteLine("понедельник");
   } 
    if (numberWeek ==2)
   {
    Console.WriteLine("вторник");
    }
    if (numberWeek ==3)
   {
    Console.WriteLine("среда");
    }
    if (numberWeek ==4)
   {
    Console.WriteLine("четверг");
    }
    if (numberWeek ==5)
   {
    Console.WriteLine("пятница");
    }
    if (numberWeek ==6)
   {
    Console.WriteLine("суббота");
    }
    if (numberWeek ==7)
   {
    Console.WriteLine("воскресенье");
   }
}
*/

Console.WriteLine("введи число дня недели от 1 до 7 ");
int numberWeek = Convert.ToInt32(Console.ReadLine());
if (numberWeek > 7|| numberWeek < 1)
{
    Console.WriteLine("введи число дня недели от 1 до 7 ");
}
else
{
    if (numberWeek ==1) Console.WriteLine("понедельник");
    if (numberWeek ==2) Console.WriteLine("вторник");
    if (numberWeek ==3) Console.WriteLine("среда");
    if (numberWeek ==4) Console.WriteLine("четверг");
    if (numberWeek ==5) Console.WriteLine("пятница");
    if (numberWeek ==6) Console.WriteLine("суббота");
    if (numberWeek ==7) Console.WriteLine("воскресенье");
}