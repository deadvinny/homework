// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double SearcEvenSub(double[] array)
{
    double sub = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) 
        {    
            max = array[i];
        }
        else
            if (array[i] < min) min = array[i];
    }
    sub = max - min;
    return sub;
}


double[] MakeNewRandomArray(int size, int beginValue, int endValue) 
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().NextDouble()*100, 2);
    return array;
}

double[] array = MakeNewRandomArray(5, 0, 100);

Console.Write("[" + string.Join(", ", array) + "]");
Console.Write($" -> разница между максимальным и минимальным значениями массива: {SearcEvenSub(array)}");