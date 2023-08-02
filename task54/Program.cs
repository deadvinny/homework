﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void FromMaxToMin(int[,] massive)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int k = 0; k < massive.GetLength(1) - 1; k++)
            {
                if (massive[i, k] < massive[i, k + 1])
                {
                    int temp = massive[i, k + 1];
                    massive[i, k + 1] = massive[i, k];
                    massive[i, k] = temp;
                }

            }
        }
    }
}

void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Введите количество строк массива: ");
int columns = GetInfo("Введите количество столбцов массива: ");

int[,] massive = DoDoubleMassive(rows, columns, 0, 9);
PrintDoubleMassive(massive);
Console.WriteLine();

Console.WriteLine("Массив после сортировки от большего к меньшему: ");
FromMaxToMin(massive);
PrintDoubleMassive(massive);