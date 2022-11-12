﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] Multiplication(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size = size + 1;

    int[] newarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newarray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) newarray[newarray.Length - 1] = arr[arr.Length / 2];
    return newarray;
}

int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);

int[] newarr = Multiplication(arr);
PrintArray(newarr);

// int[] CreateProdArray(int[] arr)
// {
// int len = arr.Length;
// int even = len % 2;

// int[] prodArr = new int[len / 2 + even];

// int i = 0;
// while (i < len / 2)
// {
// prodArr[i] = arr[i] * arr[len - 1 - i];
// i++;
// }

// if (even == 1) prodArr[i] = arr[i];
// return prodArr;
// }


// int size = 5;
// int min = 0;
// int max = 9;
// int[] array = CreateArray(size, min, max);
// Console.WriteLine("Программа находит произведение пар чисел в одномерном массиве. (Парой считаем первый и последний элемент, второй и предпоследний и т.д.) Результат записывается в новом массиве.");

// int[] prodArray = CreateProdArray(array);
// PrintArray(array);
// PrintArray(prodArray);