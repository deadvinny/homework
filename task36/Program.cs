// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SearcEvenSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (i % 2 != 0)
            {
                sum = sum + array[i];
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

int[] array = MakeNewRandomArray(4, 0, 100);

Console.Write("[" + string.Join(", ", array) + "]");
Console.Write($" ->  {SearcEvenSum(array)}.");