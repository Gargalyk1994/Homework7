// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
using System;
using static System.Console;

Write("Введите кол-во строк: ");
int rows = int.Parse(ReadLine()!);
Write("Введите кол-во столбцов: ");
int columns = int.Parse(ReadLine()!);

Write("Введите через запятую позицию элемента в массиве: ");
string[] position = ReadLine().Split(',');
int a = int.Parse(position[0]);
int b = int.Parse(position[1]);

int[,] array = GetArray(rows, columns, 0, 12);
PrintArray(array);
FindPosition(array, a, b);

int FindPosition(int[,] array, int A, int B)
{
    int[,] res = new int [array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i <= array.GetLength(0) || j <= array.GetLength(1)) 
            {
                A = i;
                B = j;           
            }    
            else WriteLine($"{A}{B} -> такого числа в массиве нет"); 
        }
    }
    return A;
    return B;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
