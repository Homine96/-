// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


string СonverterDigit(int num)
{
    string res = "";
    while (num > 0)
    {
        res = $"{(num % 2)}{res}";
        num /= 2;
    }
    return res;
}


Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(СonverterDigit(a));