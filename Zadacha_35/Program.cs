// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);

    }
    return result;
}

int[] array = GetArray(12, -100, 1000);

foreach (int i in array)
{
    Console.Write($"  {i}  ");
}

Console.WriteLine();

int Count(int[] ar)
{
    int j = 0;

    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] >= 10 & ar[i] <= 99) j = j + 1;
    }

    return j;
}

Console.WriteLine($"В интервал [10; 99] попадает {Count(array)} элемента");
