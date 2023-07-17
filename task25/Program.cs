// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double Exp(int num1, int num2)
{
    double pow = Math.Pow(num1, num2);
    return pow;
}


int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = GetInfo("Введите число A: ");
int num2 = GetInfo("Введите число B: ");


Console.WriteLine($"При возведении числа {num1} в степень {num2} получается {Exp(num1,num2)}");