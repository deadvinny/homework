// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125




void Square(int numN)
{
    Console.Write($"{numN} -> ");
    for (int i = 1; i <= numN; i++)
    {
       if (i < numN) Console.Write($"{i * i * i}, " );
       else Console.Write($"{i * i * i}." );
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numN = GetInfo("Введите число: ");
Square(numN);