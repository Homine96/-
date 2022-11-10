// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());

int MultiNumbers(int num)
{
    int multi = 1;
    for ( int i =1; i <= num ; i++)
    {
        multi *= i;
    }

    return multi;
}   
int  multinumbers = MultiNumbers(a);
Console.WriteLine($"Произведение чисел от 1 до {a} = {multinumbers}");
