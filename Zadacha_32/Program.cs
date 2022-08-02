//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] array = getArray(10, -11, 5);
int m = 0;

int[] getArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }

    return result;
}

foreach (var item in array)
{
    Console.Write(item + ", "); 
}

Console.WriteLine();  

foreach (var item in array)
{
        
    m = item * -1;
    Console.Write(m + " , "); 
}
*/


int[] array = GetArray(12, -9, 9);


int[] GetArray(int size, int min, int max)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min, max + 1);
  }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
  return result;
}

void Reverse ()
{
    for (int i = 0; i < array.Length;  i++)
    {
        array[i] = array[i]*-1;
    }
}

Reverse();
Console.WriteLine();
Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", array), "]");
