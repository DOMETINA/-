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






// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




// int[,] array = new int[3, 3];
// int sum = 0;
// int min =0;
// int minSum =0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)

//     {
//         array[i, j] = new Random().Next(1, 10);
//         Console.Write($"{array[i, j]}  ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();

// int [,] table = new int [4,4];
//         for (int i = 0; i < table. GetLength(1); i++)
//     {
//         min += table[0, i];
//     }
//     for (int i = 0; i < table. GetLength(0); i++)
//     {
//         for (int j = 0; j < table. GetLength(1); j++) sum += table[i, j];
//         if (sum < min)
//         {
//             min = sum;
//             minSum = i;
//         }
//         sum = 0;
//     }
//     System.Console.Write($"{minSum + 1} строка");



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

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число k: ");
// int k = Convert.ToInt32(Console.ReadLine());
// int[,,] array = new int[m, n, k];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (k = 0; k < array.GetLength(2); k++)
//         {
//             array[i, j, k] = new Random().Next(0, 10);
//             Console.Write($"{array[i, j, k]}  ");
//         }

//         Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07












//Сортировка двумерного массива по сторкам и столбцам.

// using System;

//     class Program
//     {
//         static void Main(string[] args)
//         {

//             int n = 4;
//             int[,] a = new int[n, n];
//             int[] temp = new int[n];

//             Random ran = new Random();
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     a[i, j] = ran.Next(1, 5);
//                     Console.Write("{0}\t", a[i, j]);
//                 }
//                 Console.WriteLine();
//             }

//             Console.WriteLine("\nСортировка по строкам: ");
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                     temp[j] = a[i, j];
//                 Array.Sort(temp);
//                 for (int k = 0; k < n; k++)
//                 {
//                     a[i, k] = temp[k];
//                     Console.Write("{0}\t", a[i, k]);
//                 }
//                 Console.WriteLine();
//             }

//             Console.WriteLine("\nСортировка по столбцам: ");
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                     temp[j] = a[j, i];
//                 Array.Sort(temp);
//                 for (int k = 0; k < n; k++)
//                     a[k, i] = temp[k];
//             }

//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                     Console.Write("{0}\t", a[i, j]);
//                 Console.WriteLine();
//             }
//         }
//     }

// Использование цикла foreach для вывода значений
// элементов массива и подсчета их суммы.
//using System;
//class ForeachDemo2
//{
//static void Main()
//{
//int sum = 0;
//int[,] nums = new int[3, 5];
// Задать первоначальные значения элементов массива nums.
// for (int i = 0; i < 3; i++)
//     for (int j = 0; j < 5; j++)
//         nums[i, j] = (i + 1) * (j + 1);


// foreach (int х in nums)
// {
//     Console.WriteLine("Значение элемента равно: " + х);
//     sum += х;
// }
// Console.WriteLine("Сумма равна: " + sum);
//}
//}










//Напишите программу, которая будет находить строку с наименьшей суммой элементов. И показывать строку 
// с минимальной суммой элементов.
// int[,] array = new int[3, 3];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write($"{array[i, j]}  ");
//     }
//     System.Console.WriteLine();
// }


//  int minRowSum = int.MaxValue, indexMinRow = 0;

//              for (int i = 0; i < array.GetLength(0); i++)
//              {
//                 int rowSum = 0;
//                 for (int j = 0; j < array.GetLength(1); j++)
//                     rowSum += array[i, j];

//                 if (rowSum < minRowSum)
//                 {
//                     minRowSum = rowSum;
//                     indexMinRow = i;
//                 }
//              }

//              Console.WriteLine("Строка с минимальной суммой элементов");
//                  for(int j = 0;j<array.GetLength(1);j++)
//                       Console.Write(array[indexMinRow, j] + "\t");




//Напишите программу, которая будет находить строку с наименьшей суммой элементов. И показывать строку 
// с минимальной суммой элементов.

// int[,] array = new int[3, 3];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write($"{array[i, j]}  ");
//     }
//     System.Console.WriteLine();
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//               sum += array[i, j];
//     }

//         Console.Write (sum +" ");
// }


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

// namespace proga
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Введите размерность матрицы (nxn)");
//             int n = Convert.ToInt16(Console.ReadLine());
//             int[,] B = new int[n, n];
//             Random rnd = new Random();
//             Console.WriteLine("Исходная матрица:");
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     B[i, j] = rnd.Next(1, 10);
//                     Console.Write("{0, 4}", B[i, j]);
//                 }
//                 Console.WriteLine();
//             }
//             Console.ReadLine();

//             int[] res1 = new int[n];  //массив для хранения сумм строк
//             int summ1 = 0;
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     summ1 += B[i, j];   //суммируем элементы строки
//                 }
//                 res1[i] = summ1; //пишем сумму в массив
//                 summ1 = 0; //обнуляем переменную
//             }

//             int max = 0;    //индекс строки с максимальной суммой
//             for (int j = 1; j < n; j++)
//             {
//                 if (res1[j] > res1[max])   //если есть строка с суммой больше, то пишем в max её индекс
//                     max = j;
//             }
//             Console.WriteLine("Номер строки с максимальной суммой элементов: "+max);
//             Console.ReadLine();

//             int[] res2 = new int[n];   //то же самое, только для столбцов
//             int summ2 = 0;
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     summ2 += B[j, i];  // индексы меняем местами, чтобы просматривались не строки, а столбцы.
//                 }
//                 res2[i] = summ2;
//                 summ2 = 0;
//             }

//             int min = 0;
//             for (int j = 1; j < n; j++)
//             {
//                 if (res2[j] < res1[min])
//                     min = j;
//             }

//             Console.WriteLine("Номер столбца с минимальной суммой элементов: " + min);
//             Console.ReadLine();

//         }
//     }
// }


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// Console.Write("Введите количество строк и столбцов nxn: ");


// int[,] array = new int[3, 3];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write($"{array[i, j]}  ");
//     }
//     System.Console.WriteLine();
// }



// namespace proga
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Введите размерность матрицы (nxn)");

//             int[,] B = new int[n, n];
//             Random rnd = new Random();
//             Console.WriteLine("Исходная матрица:");
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     B[i, j] = rnd.Next(-10, 10);
//                     Console.Write("{0, 4}", B[i, j]);
//                 }
//                 Console.WriteLine();
//             }
//Console.ReadLine();
//   int n = Convert.ToInt16(Console.ReadLine());
//             int[] res1 = new int[n];  //массив для хранения сумм строк
//             int summ1 = 0;
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     summ1 += array[i, j];   //суммируем элементы строки
//                 }
//                 res1[i] = summ1; //пишем сумму в массив
//                 summ1 = 0; //обнуляем переменную
//             }


//     //Console.Write($"{res1[i]}  ");
// int max = 0;    //индекс строки с максимальной суммой
// for (int j = 1; j < n; j++)
// {
//     if (res1[j] > res1[max])   //если есть строка с суммой больше, то пишем в max её индекс
//         max = j;

// }

//Console.WriteLine("Номер строки с максимальной суммой элементов "+ max );
// //Console.ReadLine();

// int[] res2 = new int[n];   //то же самое, только для столбцов
// int summ2 = 0;
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         summ2 += B[j, i];  // индексы меняем местами, чтобы просматривались не строки, а столбцы.
//     }
//     res2[i] = summ2;
//     summ2 = 0;
// }

// int min = 0;
// for (int j = 1; j < n; j++)
// {
//     if (res2[j] < res1[min])
//         min = j;
// }

// Console.WriteLine("Номер столбца с минимальной суммой элементов: " + min);
// Console.ReadLine();

//         }
//     }
// }

