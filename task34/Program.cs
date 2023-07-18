// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int SearcEvenSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i] % 2 == 0)
            {
                sum++;
            }
    }
    return sum;
}


int[] MakeNewRandomArray(int size, int beginValue, int endValue) 
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(beginValue, endValue);
    return array;
}

int[] array = MakeNewRandomArray(4, 100, 1000);

Console.Write("[" + string.Join(", ", array) + "]");
Console.Write($" ->  {SearcEvenSum(array)}.");