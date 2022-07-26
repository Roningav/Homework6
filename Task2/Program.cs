/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();
    for (int i = 0; i<arr.Length; i++)
    {
        arr[i] = randomizer.Next(0, 999);
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

void SummNegativeNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i< arr.Length; i++)
    {
        if (arr[i]%2 != 0)
        {
            count+=arr[i];
        }
    }
    Console.WriteLine($" Сумма нечётных чисел: {count}");
}

int[] array = GetArray(10);
PrintArray(array);
SummNegativeNumbers(array);
