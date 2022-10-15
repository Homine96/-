Console.Write("Введите имя пользователя:  ");
string? username = Console.ReadLine();

if(username.ToLower() == "алина")
{
    Console.WriteLine("УРА,Это же моя любимая сладулечка барабулечка!");
}
else
{
    Console.Write($"Hello, {username} ");
}
Console.ReadKey();