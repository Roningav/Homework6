/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();
    for (int i = 0; i<arr.Length; i++)
    {
        arr[i] = randomizer.Next(100, 999);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i< arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
}

void FindPositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i< arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($" Количество чётных чисел: {count}");
}

int[] array = GetArray(10);
FindPositiveNumber(array);
PrintArray(array);

