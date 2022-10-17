Console.Write("Введите миня пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "леночек")
{ 
    Console.WriteLine("Ура, это Леночек!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine(username);    
}