//Задача 26. Напшите программу , которая принимает на вход число
// и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2

Console.Write("Введите число:  ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int CountNumbers(int a )
{
    int count = 0;
    while(a!=0)
    {
        count++;
        a=a/10;
    }
    if (count==0) 
    {
        count=1;
    }
    return count;
}

int countnumbers=CountNumbers(num);
Console.WriteLine($"В числе {num} - { countnumbers} цифр(а)");
