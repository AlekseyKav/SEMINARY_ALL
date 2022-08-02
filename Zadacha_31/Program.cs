// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] array = GetArray(12, -9, 9);

int pos = 0;
int neg = 0;

int[] GetArray(int size, int min, int max)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min, max + 1);
  }

  return result;
}

foreach (int i in array)
{
  Console.Write(i + " ");
  pos += i > 0 ? i : 0;
  neg += i < 0 ? i : 0;
}


Console.WriteLine();
Console.WriteLine("NEG = " + neg);
Console.WriteLine("POS = " + pos);

/*
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int[] array = GetArray(12, -9, 9);

int pos = 0;
int neg = 0;

int[] GetArray(int size, int min, int max)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min, max + 1);
  }

  return result;
}

foreach (int i in array)
{
  Console.Write(i + " ");
  pos += i > 0 ? i : 0;
  neg += i < 0 ? i : 0;
}


Console.WriteLine();
Console.WriteLine("NEG = " + neg);
Console.WriteLine("POS = " + pos);
{neg} POS = {pos}");
*/