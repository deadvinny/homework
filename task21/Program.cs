// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}



int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

int x1 = GetInfo("Введите первую координату точки A: ");
int y1 = GetInfo("Введите вторую координату точки A: ");
int z1 = GetInfo("Введите третью координату точки A: ");
int x2 = GetInfo("Введите первую координату точки B: ");
int y2 = GetInfo("Введите вторую координату точки B: ");
int z2 = GetInfo("Введите третью координату точки B: ");

Console.WriteLine($"Расстояние между двумя точками на плоскости равно {Distance(x1, y1, z1, x2, y2, z2)}");