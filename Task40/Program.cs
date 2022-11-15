// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите сторону А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C");
int c = Convert.ToInt32(Console.ReadLine());

bool IsTriangle(int side1, int side2, int side3)
{
return side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2;
}
bool result = IsTriangle(a,b,c);
Console.Write( result == true? "Yes": "No" );
// дальше вывод через тернарный оператор