// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 5)
// {
//     Console.Write(num + num);
// }
// else
// {
//     Console.Write(num % 2);
// }

// Console.Write("Введите число1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
// {
//     Console.Write("yes");
// }
// else
// {
//     Console.Write("no");
// } 


// 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите число1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// max = Convert.ToInt32(Console.ReadLine());
// if (num1 + num2 == max)
   
// {
//     Console.Write("max");
// }

// int num1 = 3;
// int num2 = 2;
// Console.WriteLine(num1 / num2);


// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int a = num1;
int b = num2;

int max = a;

if (a > b) max = a;

if (a < b) max = b;

Console.WriteLine("max =");
Console.Write(max);
