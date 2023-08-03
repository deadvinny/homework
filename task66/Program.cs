// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromTo(int firstNumber, int secondNnumber)
{
    int sum = firstNumber;
    if (firstNumber == secondNnumber) return 0;
    else
    {
        firstNumber++;
        sum = firstNumber + SumFromTo(firstNumber, secondNnumber);
        return sum;
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int firstNumber = GetInfo("Введите первое число число: ");
int secondNnumber = GetInfo("Введите второе число: ");
Console.WriteLine($"Сумма чисел от {firstNumber} до {secondNnumber} -> {SumFromTo(firstNumber - 1, secondNnumber)}");