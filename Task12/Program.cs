//программа, которая показывает кратно ли первое число второму и если не кратно , то выводит остаток

Console.Write("Введите число №1 :   ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2 :   ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Ostatok(int arg1, int arg2)
{
    return arg1 % arg2;
}

int num3 = Ostatok(num1, num2);
Console.WriteLine(num3 == 0 ? "кратно" : $"не кратно, остаток {num3}");