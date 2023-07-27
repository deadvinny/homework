// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double GetInfo(string message)
{
    Console.Write(message);
    double inputNum = Convert.ToDouble(Console.ReadLine());
    return inputNum;
}

double b1 = GetInfo("Введите первую координату первой точки: ");
double b2 = GetInfo("Введите вторую координату первой точки: ");
double k1 = GetInfo("Введите первую координату второй точки: ");
double k2 = GetInfo("Введите вторую координату второй точки: ");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");