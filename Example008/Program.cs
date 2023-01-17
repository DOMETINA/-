// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива.
Console.Write("Введите число m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]}  ");
    }


}
Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
    int temp = array[0, j];
    array[0, j] = array[array.GetLength(1) - 1, j];
    array[array.GetLength(1) - 1, -j] = temp;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]}  ");
    }
System.Console.WriteLine();
}


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.









