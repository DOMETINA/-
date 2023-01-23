// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Задачи на семинаре (класнная работа)
// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 10);
//     Console.Write($"{array[i]}   ");
// }
// System.Console.WriteLine();
// int[] array1 = new int[5];
// for (int i = 0; i < array1.Length; i++)
// {
//     array1[array.Length-1-i] = array[i];
// }
// for (int i = 0; i < array1.Length; i++)
// {
//     Console.Write($"{ array1[i]}   ");
// }


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
//треугольник с сторонами такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника 
//меньше суммы двух других сторон. 
// Console.Write("Введите длину стороны а: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длину стороны b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длину стороны c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a < b + c && b < a + c && c < a+ b)
// System.Console.WriteLine("Треугольник существует");
// else
// System.Console.WriteLine("Треугольник не существует");

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int n = num;
// string result = " ";

// while (n > 0)
// {
// result = n % 2 + result;
// n = n/2;
// }
// System.Console.WriteLine(result);


//ДОМАШНЕЕ ЗАДАНИЕ
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] array = new int[10];
int x = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write($"{array[i]}   ");
}
System.Console.WriteLine();
for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
    {
    x = x +1;                  
    }
Console.Write($"{x}   ");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// System.Console.Write("Введите значения b1 ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите значения k1 ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите значения b2 ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите значения k2 ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// if (k1==k2 && b1==b2)
// {
//     System.Console.WriteLine("Линии совпадают");
// }
// else if (k1==k2 ||b1==b2)
// {
//     System.Console.WriteLine("Линии не пересекаются");
// }
// else if (k1!=k2 && b1!=b2)
// {
// double x = (b2-b1)/(k1-k2);
// double y = k1*x +b1;
//     System.Console.WriteLine($"Линии пересекаются в точке ({x},{y})" );
// }


