// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;// чтобы не писать Console 
Write("Введите кол-во строк: ");
int rows = int.Parse(ReadLine()!);
Write("Введите кол-во столбцов: ");
int columns = int.Parse(ReadLine()!);

double[,] array = GetArray(rows, columns, 0.5, 11.8);
PrintArray(array);
WriteLine();

// Write($"Сумма чисел главной диагонали: {FindSumDiagonalNum(array)}");
// Write($"Сумма чисел главной диагонали: {GetSum(array)}");

//array = FindArrayUnevenNum(array);
//PrintArray(array);
//WriteLine();

//PrintArray(FindArrayUnevenNum(array));

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]:f2} ");
        }
        WriteLine();
    }
}

// int FindSumDiagonalNum (int[,] array)
// {
//     int[,] res = new int [array.GetLength(0), array.GetLength(1)];
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j) 
//             {
//                 sum += array[i, j];           
//             }    
//                 else res[i, j] = array[i, j]; 
//         }
//     }
//     return sum;
// }
// //или замена Функции FindSumDiagonalNum -> функция GetSum
// int GetSum(int[,] array)
// {
//     int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(0); // если array.GetLength(0) < array.GetLength(1) то в результат запишем array.GetLength(0) иначе array.GetLength(1)
//     int sum = 0;
//     for (int i = 0; i < length; i++)
//     {
//         sum += array[i, i]; 
//     }
//     return sum;
// }

