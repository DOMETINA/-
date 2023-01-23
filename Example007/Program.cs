// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задачи на семинаре (кассная работа)
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Write("Введите число строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)

//     {
//         array[i, j] = new Random().Next(-9, 10);
//         Console.Write($"{array[i, j]}   ");
//     }
//     System.Console.WriteLine();
// }


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// Console.Write("Введите число строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)

//     {
//         array[i, j] = i +j;
//         Console.Write($"{array[i, j]}   ");
//     }
//     System.Console.WriteLine();
// }


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы 
//на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 

// Console.Write("Введите число строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)

//     {
//         array[i, j] = new Random().Next(1, 10);
//         Console.Write($"{array[i, j]}   ");
//     }
//     System.Console.WriteLine();

// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)

//         array[i, j] = array[i, j] * array[i, j];
//         Console.Write($"{array[i, j]}   ");
//     }
//     Console.WriteLine();
// }





// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.Write("Введите число строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)

//     {
//         array[i, j] = new Random().Next(1, 10);
//         if (i == j)
//         sum = sum + array[i, j];
//         Console.Write($"{array[i, j]}   ");
//     }
//     System.Console.WriteLine();
// }
// Console.Write($"Сумма={sum}   ");


// Доп.задание: x1 ^ 5 + x2 ^ 5 + x3 ^ 5 + x4 ^ 5 = x5 ^ 5
// Сумма 4 чисел в 5 степени равна пятому числу в пятой степени
// Нужно найти эти числа


// ДОмашняя работа
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] array = new double [3,4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)

//     {
//         array[i, j] = new Random().NextDouble(); 
//         Console.Write($"{array[i, j]}   ");
//     }
//     System.Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            //Console.Write($"{array[i, j]}   ");
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.Write("]");
    }
}

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];

FillArray(arr);
PrintArray(arr);

if (m > arr.GetLength(0) || n > arr.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}

else
{
    //Console.WriteLine($"Значение элемента {m} строки и столбца {n} равно {arr[m-1,n-1]}");
    Console.WriteLine($"Значение элемента {arr[m - 1, n - 1]}");
}



Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)

    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]}   ");
    }
    System.Console.WriteLine();
}

if (m > array.GetLength(0) || n > array.GetLength(1))
{
    Console.Write("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {array[m - 1, n - 1]}");
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Console.Write("Введите число строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// double sum = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//         Console.Write($"{array[i, j]}   ");

//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();
// //   for (int i = 0; i < array.GetLength(0); i++)

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = (sum + array[i, j]);

//     }
//     double result = sum / array.GetLength(0);
//     Console.Write($"{Math.Round(result, 3)}   ");
//     sum = 0;
// }
// System.Console.WriteLine();
