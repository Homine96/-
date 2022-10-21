// Напшите программу, которая по заданному номеру четверти,показывает дипазон
// возможных координат точек в этой четверти

// Console.WriteLine("Введите номер четверти: ");
// int number = Convert.ToInt32(Console.ReadLine());

// string Quarter2(int num)
// {
//     if (num==1) return "x>0 и y>0" ;
//     if (num==2) return "x<0 и y>0";
//     if (num==3) return "x<0 и y<0";
//     if (num==4) return "x>0 и y<0";
//      return null;
// }

// string? quater = Quarter2(number);

// Console.WriteLine(quater == null
// ? "Некорректный номер четверти"
// : $"Диапазон возможных координат точек в этой четверти: {quater}");





// System.Console.Write("Введите номер четверти ");
// int quarter = Convert.ToInt32(Console.ReadLine());

// string Range(int q)
// {
// string answer;
// switch (q)
// {
// case 1: answer=$" x > 0 и y > 0"; break;
// case 2: answer= $" x < 0 и y > 0"; break;
// case 3: answer= $" x < 0 и y < 0"; break;
// case 4: answer=$" x > 0 и y < 0"; break;
// default: answer=$"Не корректные данные"; break;
// }
// return answer;
// }
// System.Console.WriteLine(Range(quarter));



string Range(int quarter)
{
    switch (quarter)
    {
        case 1:
            return "x > 0 и y > 0";
        case 2:
            return "x < 0 и y > 0";
        case 3:
            return "x < 0 и y < 0";
        case 4:
            return "x > 0 и y < 0";
        default:
            return "Некорректные данные";
    }
}
Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Range(quarter));