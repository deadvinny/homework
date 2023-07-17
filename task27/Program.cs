// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSize(int num)
{
    int sum = 0;
    int div = 0;
    int size = 0;
    while (num > 0)
    {
        div = num % 10;
        sum = sum + div;
        num = num / 10;
        size++;
    }
    return sum;
}


int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число: ");


Console.WriteLine($"В числе {num} - сумма цифр равна {GetSize(num)}.");