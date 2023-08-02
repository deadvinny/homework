// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void WhereMinSum(int[,] massive)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            temp += massive[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = i;
        }
    }
    Console.Write($"Наименьшая сумма {sum} находится в строке {index +1}: ");
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        Console.Write($"{massive[index, i]} ");
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

WhereMinSum(massive);