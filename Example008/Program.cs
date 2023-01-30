// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива.
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write($"{array[i, j]}  ");
//     }

// Console.WriteLine();
// }
// Console.WriteLine();
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     int temp = array[0, j];
//     array[0, j] = array[array.GetLength(1) - 1, j];
//     array[array.GetLength(1) - 1, j] = temp;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write($"{array[i, j]}  ");
//     }
// System.Console.WriteLine();
// }


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// if (m != n)

//     System.Console.Write("Заменить не возможно");


// else
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write($"{array[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
//     System.Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[j, i]}  ");
//         }
//         System.Console.WriteLine();
//     }

// }
// ДОМАШНЕЕ ЗАДАНИЕ.
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] array = new int[3, 6];
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             array[i, j] = new Random().Next(1, 10);
//             Console.Write($"{array[i, j]}  ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 while (array[i, k] < array[i, k + 1])
//                 {
//                     int temporary = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temporary;
//                 }
//             }
//         }
//     }
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write($"{array[i, j]}  ");
//     }
//     System.Console.WriteLine();
// }



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
//double[] array = new double[5];
//double result = 0;
// double max = 0;
// double min = 1;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().NextDouble();
//     System.Console.Write($"{array[i]}  ");
//     if (array[i] > max)
//         max = array[i];

//         System.Console.WriteLine();
// }
// System.Console.WriteLine($"max = {max} ");
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < min)
//         min = array[i];
// }
// System.Console.Write($"min = {min}  ");
// System.Console.WriteLine();
// System.Console.Write($"{max - min}  ");


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




int[,] array = new int[3, 3];
int sum = 0;
int min =0;
int minSum =0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)

    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]}  ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         System.Console.WriteLine();
//     }
// }
int [,] table = new int [3,3];
        for (int i = 0; i < table. GetLength(1); i++)
    {
        min += table[0, i];
    }
    for (int i = 0; i < table. GetLength(0); i++)
    {
        for (int j = 0; j < table. GetLength(1); j++) sum += table[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    System.Console.Write($"{minSum + 1} строка");



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07






