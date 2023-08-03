// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int firstNumber, int secondNnumber)
{
    if (firstNumber == 0) return secondNnumber + 1;
    else if (firstNumber > 0 && secondNnumber == 0) return AkkermanFunction(firstNumber - 1, 1);
    else return AkkermanFunction(firstNumber - 1, AkkermanFunction(firstNumber, secondNnumber - 1));
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int firstNumber = GetInfo("Введите неотрицательное число: ");
int secondNnumber = GetInfo("Введите второе неотрицательное число: ");
Console.WriteLine($"А ({firstNumber}, {secondNnumber}) = {AkkermanFunction(firstNumber, secondNnumber)}");