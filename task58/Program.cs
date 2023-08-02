// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



void MultiplyMassive(int[,] massiveFirst, int[,] massiveSecond, int[,] massiveResult)
{
    for (int i = 0; i < massiveResult.GetLength(0); i++)
    {
        for (int j = 0; j < massiveResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < massiveFirst.GetLength(1); k++)
            {
                sum += massiveFirst[i, k] * massiveSecond[k, j];
            }
            massiveResult[i, j] = sum;
        }
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

void PrintDoubleMassive(int[,] massiveResult)
{
    for (int i = 0; i < massiveResult.GetLength(0); i++)
    {
        for (int j = 0; j < massiveResult.GetLength(1); j++)
        {
            Console.Write($"{massiveResult[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintDoubleMassiveFirst(int[,] massiveFirst)
{
    for (int i = 0; i < massiveFirst.GetLength(0); i++)
    {
        for (int j = 0; j < massiveFirst.GetLength(1); j++)
        {
            Console.Write($"{massiveFirst[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintDoubleMassiveSecond(int[,] massiveSecond)
{
    for (int i = 0; i < massiveSecond.GetLength(0); i++)
    {
        for (int j = 0; j < massiveSecond.GetLength(1); j++)
        {
            Console.Write($"{massiveSecond[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassiveFirst(int rowsFirst, int columnsAndRows, int minValue, int maxValue)
{
    int[,] result = new int [rowsFirst, columnsAndRows];
    for (int i = 0; i < rowsFirst; i++)
    {
        for (int j = 0; j < columnsAndRows; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }    
    return result;
}

int[,] DoDoubleMassiveSecond(int columnsAndRows, int columnsSecond, int minValue, int maxValue)
{
    int[,] result = new int [columnsAndRows, columnsSecond];
    for (int i = 0; i < columnsAndRows; i++)
    {
        for (int j = 0; j < columnsSecond; j++)
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

int rowsFirst = GetInfo("Введите количество строк первого массива: ");
int columnsAndRows = GetInfo("Введите количество столбцов первого массива и строк  второго массива: ");
int columnsSecond = GetInfo("Введите количество столбцов второго массива: ");

int[,] massiveFirst = DoDoubleMassiveFirst(rowsFirst, columnsAndRows, 0, 9);
PrintDoubleMassiveFirst(massiveFirst);
Console.WriteLine();
int[,] massiveSecond = DoDoubleMassiveSecond(columnsAndRows, columnsSecond, 0, 9);
PrintDoubleMassiveSecond(massiveSecond);
Console.WriteLine();

int[,] massiveResult = DoDoubleMassive(rowsFirst, columnsSecond, 0, 9);
MultiplyMassive(massiveFirst, massiveSecond, massiveResult);
PrintDoubleMassive(massiveResult);