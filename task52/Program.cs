// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void MidSum(int[,] massive)
{
    Random rand = new Random();
    for (int j = 0; j < massive.GetLength(1); j++)//int i = 0; i < massive.GetLength(0)+1; i++)
    {
        double sum = 0;
        for (int i = 0; i < massive.GetLength(0); i++)//int j = 0; j < massive.GetLength(1)+1; j++)
        {
            sum = sum + massive[i,j];
                
        }
        Console.Write($" {sum / (massive.GetLength(0)):F1}");
    }
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

int[,] massive = DoDoubleMassive(rows, columns, 0, 9);
PrintDoubleMassive(massive);
MidSum(massive);