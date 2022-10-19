/*Программа, которая выводит случайное число
из отрезка [10,99] и показывает наибольшую цифру числа*/
// 78->8
//12 -> 2
// 85 -> 8

int num = new Random().Next(10, 100);
Console.Write($"Случайное число из диапазона 10-99 -> {num} ");

// int firtsDigit = num / 10;
// int secondDigit = num % 10;

// if (firtsDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firtsDigit}");
// else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

// int max = Math.Max(firtsDigit,secondDigit);
// Console.WriteLine($"Наибольшая цифра числа {num} = {max} ");

// int result = firtsDigit > secondDigit ? firtsDigit : secondDigit;
//  Console.WriteLine($"Наибольшая цифра числа {num} = {result} ");

int MaxDigit(int number)
{
    int firtsDigit = number / 10;
    int secondDigit = number % 10;
    return firtsDigit > secondDigit ? firtsDigit : secondDigit;
}

int max = MaxDigit( num);
Console.Write (max);