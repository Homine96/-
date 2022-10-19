//написать программу, которая выдает случайное трехзначное число
// и  удаляет вторую цифру
int NumberRandom(int num)
{
    int num1= num/100;
    int num2=num%10;
    int result=num1*10+num2;
    return result;
}

int num = new Random().Next(100,1000);
Console.WriteLine($"Трехзначное число = {num}");

int finalnumber= NumberRandom(num);
Console.WriteLine ($"Двузначное число = {finalnumber}");
