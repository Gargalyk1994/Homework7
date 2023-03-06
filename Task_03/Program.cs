// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using System;
using static System.Console;
Write("Введите кол-во строк: ");
int rows = int.Parse(ReadLine()!);
Write("Введите кол-во столбцов: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
WriteLine($"{String.Join("; ", GetArithmeticMean(array))}");//Кирилл как сократить вещесвенное число:
                                                            //к примеру: не 2,453212  а 2,45. f2 не знаю как записать



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

double[] GetArithmeticMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    double length = array.GetLength(0);
    for (int i = 0; i < array.GetLength(0) || i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1) && j < array.GetLength(0); j++)
        {
            sum += array [j, i];
        }
        result[i] = sum / length;
        sum -= sum;
    }
    return result; 
}