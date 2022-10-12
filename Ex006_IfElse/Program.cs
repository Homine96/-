Console.Write("Введите имя пользователя:  ");
string username = Console.ReadLine();

if(username.ToLower() == "алина")
{
    Console.WriteLine("УРА,Это же АЛИНА!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}