﻿// See https://aka.ms/new-console-template for more information
// Consol e.WriteLine("Hello, World!");



// int num1 = 13;
// int num2 = 5;
// if (num1 > 3 &&  num2 > 3)
// {
//     Console.Write("yes");
// }
// else
// {
//     Console.Write("no");
// } 



// double num1 = 3;
// // int num2 = 5;

// for(int i = 1; i < 7; i ++)
// {
//    Console.WriteLine(i);
// }

//    Console.WriteLine("OK");




// double num1 = 2;

// while (num1 < 10)
// {
//     Console.WriteLine(num1);
//     num1 += 2;
// }

// Console.WriteLine("OK");




// double num1 = 3;
// // int num2 = 5;

// for (int i = 1; i < 7; i++)
// {
//     if (i == 3 || i == 4) continue;

//     Console.WriteLine(i);
// }

// Console.WriteLine("OK");



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









// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

    Console.Write ((num / 10) %10);








// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// if ( num <= 99 )
// {
//     Console.Write("Третьей цифры нет");
// }
// else if (num == 100 ||  num < 999)
// {
//     Console.Write(num % 10);
// }
//  else if (num >= 999)
// {
//     while  (num >= 999) 
//     {
//         num = num /10;
//     }
//     Console.WriteLine(num%10);   
// }
    



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// Console.Write("Введите число дня недели : ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 6 || num == 7)

//     Console.Write("Да");

// else

//     Console.Write("Нет");


