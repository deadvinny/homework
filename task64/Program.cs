// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Numbers(int num)
{
    if (num > 1) return $"{num}, " + Numbers(num - 1);
    else return "1";
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число N: ");
Console.WriteLine($"N = {num}, все числа от него до 1: {Numbers(num)}");