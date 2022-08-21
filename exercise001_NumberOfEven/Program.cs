// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] col)
{
    for (int count = 0; count < col.Length; count++)
    {
        Console.Write($"{col[count]}\t");
    }
}

int evenCounter(int[] coll)
{
    int evenMeter = 0;
    for (int j = 0, z = coll.Length; j < z; j++)
    {
        if (coll[j] % 2 == 0) {evenMeter++;}
    }
    return evenMeter;
}

int[] array = new int[7];
FillArray(array);
PrintArray(array);
Console.WriteLine($"\nКоличество четных чисел в массиве = {evenCounter(array)}");
