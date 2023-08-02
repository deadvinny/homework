// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (massive[i, j] / 10 <= 0) Console.Write($" {massive[i, j]} ");
            else Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] DoDoubleMassive(int rowsColumns)
{
    int[,] massive = new int[rowsColumns, rowsColumns];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= massive.GetLength(0) * massive.GetLength(1))
    {
        massive[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < massive.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= massive.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > massive.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return massive;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rowsColumns = GetInfo("Укажите, сколько строк и столбцов будет в спиральном массиве: ");

int[,] massive = DoDoubleMassive(rowsColumns);
PrintDoubleMassive(massive);
Console.WriteLine();