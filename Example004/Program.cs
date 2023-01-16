// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//СЕМИНАР Задачи на уроке.
// Задача 24:Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int result = 0;
// for (i = 0; i <= num; i++)
// {
//     result = result + i;
// }
// Console.WriteLine(result);






// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int i = 0;

// while (num > 0)
// {
//     i++;
//     num = num / 10;
// }
//     Console.WriteLine(i);


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// int result = 1;
// for (i = 1; i <= num; i++)
// {
//     result = result * i;
// }
// Console.WriteLine(result);

//Задача 30: Напишите программу,которая выводит массив из 8 элементов, заполнненый нулями и единицами
// в случайном порядке
// [1,0,1,1,0,1,0,0]

// int[] array = new int [8];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 2);
// Console.Write($"{ array [i]} ");
//}


// Домашнее задание

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// double a = num1;
// double b = num2;

// Console.WriteLine(Math.Pow(a, b));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//  Console.Write("Введите число: ");
//  int num = Convert.ToInt32(Console.ReadLine());
//  int result = 0;
 
//  int[] array = {num};
//  for (int i = 0; i < num; i++)
//  {
//     System.Console.Write($"{array[i]}  ");
//     if (i < num)
//     result = result + array[i];
//  }
// Console.WriteLine(result);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array =  new int [8];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 20);
// Console.Write($"{ array [i]} ");
// }

