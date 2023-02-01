
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введите число N:  ");
// int N = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(PrintNamber( N ));

// string PrintNamber( int N)
// {
//     if ( N  <= 1) return "1";


//        return PrintNamber(N - 1) + N;  

//}
//string PrintNamber(num)
//System.Console.WriteLine(PrintNamber(num));


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Write("Введите число M:  ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int N = Convert.ToInt32(Console.ReadLine());
int Nat (int N, int M)
{
    if (N == M)
    {
        return N;
    }
    Console.Write(N);
    return Nat (N- 1, M);
}
    int x = Nat(N, M);
System.Console.Write(x);

