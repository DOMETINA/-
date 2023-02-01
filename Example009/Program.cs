//Рекурсивный метод. Пример : факториал из 5.

// int Fact(int num)
// {
// if (num == 1)
// {
// return 1;
// }

// return num * Fact(num - 1);
// }

// int x = Fact(5);
// Console.WriteLine(x);




// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"




// Console.Write("Введите число N:  ");
// int N = Convert.ToInt32(Console.ReadLine());
// int Nat (int N)
// {
//     if (N == 1) 
//     {
//          return 1; 
//     }

//     Console.Write(N);
//     return Nat (N - 1);
// }
//     int x = Nat(N);
// System.Console.Write(x);

//Второе решение

// Console.Write("Введите число N:  ");
// int N = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(PrintNamber( N ));

// string PrintNamber( int N)
// {
//     if ( N  <= 1) return "1";


//        return PrintNamber(N - 1) + N;  

// }
// PrintNamber(N);
//System.Console.WriteLine(PrintNamber(N));


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Write("Введите число M:  ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int N = Convert.ToInt32(Console.ReadLine());
int Nat(int N, int M)
{
    if (N == M)
    {
        return N;
    }
    Console.Write(N);
    return Nat(N - 1, M);

}
int x = Nat(N, M);
System.Console.Write(x);


// Stanislav N: Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// Console.Write("Введите число N:  ");
// int N = Convert.ToInt32(Console.ReadLine());
// int Nat (int N)
// {
//     if (N % 10 ==0) 
//     {
//          return 0; 
//     }

//     return (N % 10 + Nat ( N/10));
// }
//     int x = Nat(N);
// System.Console.Write(x);




// Stanislav N: Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29