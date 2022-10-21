// Напишите программу, которая принимает на вход коордитнаты Х и У 
// причем Х и У != 0 и выдает номер четверти

int Quarter(int a, int b)
{
    if (a > 0 && b > 0) return 1;
    if (a < 0 && b > 0) return 2;
    if (a < 0 && b < 0) return 3;
    if (a > 0 && b < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты Х и У");
Console.Write("X:  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:  ");
int y = Convert.ToInt32(Console.ReadLine());

if (Quarter(x, y) == 0) Console.WriteLine("Введены некоректные данные");
else Console.WriteLine($"Номер четверти -> {Quarter(x, y)}");
