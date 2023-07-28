// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void SearchNum(int[,] massive, int number1, int number2)
{
    for (int i = 0; i < massive.GetLength(0)+1; i++)
    {
        for (int j = 0; j < massive.GetLength(1)+1; j++)
        {
            if (i == number1 & j == number2) 
            {
                Console.WriteLine($"Число с данными индексами {massive[i-1,j-1]}");
            }
        }
    }
    if (number1 > massive.GetLength(0) || number2 > massive.GetLength(1)) Console.WriteLine("Такого элемента нет в массиве");
}

void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++) // (0) - строки (длинна строк массива)
    {
        for (int j = 0; j < massive.GetLength(1); j++) // (1) - столцы (длинна столбцов массива)
        {
            Console.Write($"{massive[i,j]} ");
        }
    Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int [rows, columns];
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
int number1 = GetInfo("Введите индекс строки элемента массива: ");
int number2 = GetInfo("Введите индекс столбца элемента массива: ");

int[,] massive = DoDoubleMassive(rows, columns, 0, 9);
PrintDoubleMassive(massive);
SearchNum(massive,number1,number2);