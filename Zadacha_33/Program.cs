//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


int[] array = GetArray(12, -9, 9);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
    return result;
}

string Search(int x)
{
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == x) 
        {
            return "Да, присутствует";
        }
    }

    return "Не присутствует";
}
Console.WriteLine(Search(2));
