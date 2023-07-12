// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



void CheckingNumber(int number)
{
    if (number > 9999 & number < 100000)
    {
        if (number % 10 == number / 10000 || number % 100 / 10 == number / 1000 % 10)
        {
            Console.WriteLine($"{number} -> да");
        }
        else 
        {
            Console.WriteLine($"{number} -> нет");
        }
    }
    else Console.WriteLine($"неверное число");
}


int GetInfo(string message)
{
     Console.Write(message);
     int numQuarter = Convert.ToInt32(Console.ReadLine());
     return numQuarter;
}

int number = GetInfo("Введите число: ");
CheckingNumber(number);
