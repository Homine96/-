// Напишите программу, которая на вход
// 1.на вход принимает число 
// 2.выдаёт его квадрат.

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write ("Введите целое число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number ;
Console.WriteLine($"Квадрат числа {number} = {square}");