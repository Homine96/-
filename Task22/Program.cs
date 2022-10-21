// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void Table(int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.WriteLine($"{index,4} {index * index,4}");
        index++;
    }
}

Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0) Table(n);
else Console.WriteLine("Введено некорректное число");