// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива.

Console.Write("Введите число m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];
for (int i = 0; i < array.GetLength (0); i++)
{
   for (int j = 0; j < array.GetLength (1); j++)
   {
    array[i,j] = new Random().Next(0,10);
    System.Console.WriteLine($"{array [m,n]}  ");
   }
System.Console.WriteLine();
}







// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.