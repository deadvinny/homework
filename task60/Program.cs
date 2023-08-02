// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintTripleMassive(int[,,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(2); k++)
            {
                Console.Write($"{massive[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

bool FindElement(int[,,] massive, int num)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(2); k++)
            {
                if (massive[i, j, k] == num) return true;
            }
        }
    }
    return false;
}

int[,,] DoTripleMassive(int rows,int columns,int deep,int minValue,int maxValue)
{
    int[,,] result = new int [rows, columns, deep];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int k = 0;
            while (k < deep)
            {
                int number = new Random().Next(minValue, maxValue + 1);
                if (FindElement(result, number)) continue;
                result[i, j, k] = number;
                k++;
            }
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
int deep = GetInfo("Введите глубину массива: ");

int[,,] massive = DoTripleMassive(rows, columns, deep, 10, 99);
PrintTripleMassive(massive);
Console.WriteLine();