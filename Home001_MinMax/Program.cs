int a = 2;
int b = 10;

int max = a;
int min = a;

if(a > max) max = a;
if(b > max) max = b;
Console.WriteLine("max = ");
Console.WriteLine(max);

if(min > a) min = a;
if(min > b) min = b;
Console.WriteLine("min = ");
Console.WriteLine(min);