// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Console.Write("Введите число 1: ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число 2: ");
// double num2 = Convert.ToDouble(Console.ReadLine());
// if (num1 == num2 * num2)
// {
//    Console.WriteLine("кратно");
// }
// else 
// {
//       Console.Write("не кратно, остаток ");
//     Console.Write(num1 / num2);
// }



// Console.Write("Введите число1: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число2: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//   Console.WriteLine("1 четверть");
// }
// else if (x < 0 && y > 0)
// {
//   Console.WriteLine("2 четверть");
// }
// else if (x < 0 && y < 0)
// {
//   Console.WriteLine("3 четверть");
// }

// if (x > 0 && y < 0)
// {
//   Console.WriteLine("4 четверть");
// }


// Задача 23// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int [] nums = new int [num];

// for (int i = 0; i < num; i++)
// {
//   nums [i] = (i+1) * (i+1)* (i+1);
//   Console.WriteLine(nums[i]);
// }





// Задача 21// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.5
// Console.Write("Введите число A: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число A: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число A: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число B: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число B: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число B: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double r = x1 - x2;
// double r1 = Math.Pow (r, 2);

// double m = y1 - y2;
// double m1 = Math.Pow (m, 2);

// double i = z1 - z2;
// double i1 = Math.Pow (i, 2);
// Console.WriteLine(Math.Sqrt((r1)+(m1)+(i1)));
// Console.WriteLine(Math.Round((Math.Sqrt((r1)+(m1)+(i1))),2));





// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// onsole.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// double num1 = num / 10000;
// double num2 = (num % 10000) / 1000;
// double num3 = (num % 1000) / 100;
// double num4 = (num % 100) / 10;
// double num5 = num % 10;
// if (num1 == num5 && num2 == num4)
// {
//     Console.WriteLine("да");
// }C
// else
// {
//     Console.WriteLine("нет");
// }

// double num3 = num  /10000;
// double num4 = num  /10000;
// double num5 = num  /10000;
// {
//   int [] nums = new int [num];
//   for (int i = 0; i < num; i++)
//   {
//     nums [i] = i + 1;
//     Console.WriteLine (nums [1]);
//   }
// }
// else
// {
//   Console.WriteLine ("нет") ;
// }
// for (int i = 0; i < num; i++)

//   Console.WriteLine (num) ;


