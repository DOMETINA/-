// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежуткка [-9.9]. Найти 
//сумму отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, отрицательных чисел -20.

// int [] array = new int [12];
// int sam1 = 0;
// int sam2 = 0;
// for (int i = 0; i < 12; i++)
// {
//     array[i] = new Random().Next(-9,10);
//     Console.Write( array[i]);
//     if (array[i] < 0) sam1 = sam1 + array[i];
//     if (array[i] > 0) sam2 = sam2 + array[i];

// }
// Console.WriteLine( sam1);
// Console.WriteLine(sam2);


// Задача 32: напишите программу замена элементов массива: положительные элементы заменить на 
//соответствующие отрицательные , и наоборот.
// [-4,-8,8,2] --[4,8,-8,-2]

// int[] array = new int[4];

// for (int i = 0; i < 4; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     Console.Write(array[i]);
// }
// Console.WriteLine();


// for (int i = 0; i < 4; i++)
// {
//     array[i] = -1 * array[i];
//     Console.Write(array[i]);
// }



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6,7,19,345,3] -- нет
// 3; массив [6,7,19,345,3] -- да

//  Console.Write("Введите число: ");
//  int num = Convert.ToInt32(Console.ReadLine());
//  int x = 0;
// int [] array =  {6,7,19,345,3,5};
//  for (int i = 0; i < 6; i++)
//  {
//     System.Console.WriteLine(array[i]);
//  }
//   for (int i = 0; i < 6; i++)
// {
//       if ( array[i] == num)
//       {
//         x = 1;
//       }
//  }

//  if (x == 1)
//  {
//     System.Console.WriteLine("да");
//  }

//       else 

//     System.Console.WriteLine("нет");
//второе решение задачи 33, с массивом из случайных чисел.
//  Console.Write("Введите число: ");
//  int num = Convert.ToInt32(Console.ReadLine());
//  int x = 0;
// int [] array =  new int [5];
//  for (int i = 0; i < 5; i++)
//  {
//     array[i] = new Random().Next(-9, 10);
//     System.Console.WriteLine(array[i]);
//  }
//   for (int i = 0; i < 5; i++)
// {
//       if ( array[i] == num)
//       {
//         x = 1;
//       }
//  }

//  if (x == 1)
//  {
//     System.Console.WriteLine("да");
//  }

//       else 

//     System.Console.WriteLine("нет");


//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найти количество элементов массива, 
//значения которых лежат в отрезке [10,99]. пример для массива из 5, а не из 123. В своем решениисделайте для 123.
// [5,18,123,6,2] --1
// [1,2,3,6,2]--0
// [10,11,12,13,14]--5


//Console.Write("Введите число: ");
//  int num = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// int[] array = new int[123];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,100);
//     System.Console.Write($"{array[i]}  ");
//    if (array[i] > 10 && array[i] < 99) 
//    result++;
// }
// System.Console.WriteLine();
// System.Console.WriteLine();
//   System.Console.WriteLine(result);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элементы,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1,2,3,4,5]-- 5,8,3
// [6,7,3,6]-- 36,21


//Домашнее задание

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] array = new int[10];
// int result = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(100,1000);
//     System.Console.Write($"{array[i]}  ");
//    if (array[i] % 2 ==0) 
//    result++;
// }
// System.Console.WriteLine();
// System.Console.WriteLine();
//   System.Console.WriteLine(result); 



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


//int[] array = new int[5];
// int result = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(1,20);
//     System.Console.Write($"{array[i]}  ");
//    if (i % 2 !=0) 
//    result = result + array[i];
// }
// System.Console.WriteLine();
// System.Console.WriteLine();
//   System.Console.WriteLine(result); 


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array = new double[5];

// //double result = 0;
// int i = 0;
// double max = 0;
// double min = 0;

// while (i < array.Length)
// {
//    array[i] = new Random().NextDouble();
//      System.Console.WriteLine($"{array[i]}  ");
//     if (array[i] >max)
//     max = array[i];
//     System.Console.Write($"max = {max}  ");
// }
// {
//     if (array[i] < min)
//     min = array[i];
//      System.Console.Write($"min = {min}  ");
// }
    


// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().NextDouble();
//     System.Console.WriteLine($"{array[i]}  ");
//     if (array[i] > max)
//         max = array[i];
//     {
//         x = 1;
//     }
//     if (x == max)
//         System.Console.WriteLine();
// }
// System.Console.Write($"max = {max}  ");
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < min)

//         //i++;
// array[i] = array[i] +1;
//     System.Console.WriteLine();
// }
// System.Console.Write($"min = {min}  ");
// System.Console.WriteLine();
// System.Console.WriteLine();
// System.Console.Write($"{max - min}  ");







// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] array = new double[5];
//double result = 0;
double max = 0;
double min = 1;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    System.Console.Write($"{array[i]}  ");
    if (array[i] > max)
        max = array[i];
   
        System.Console.WriteLine();
}
System.Console.WriteLine($"max = {max} ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
}
System.Console.Write($"min = {min}  ");
System.Console.WriteLine();
System.Console.Write($"{max - min}  ");

