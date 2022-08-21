// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] collection)
{
    for (int i = 0, arraySize = collection.Length; i < arraySize; i++)
    {
        collection[i] = Math.Round(new Random().NextDouble() * 100, 3);
    }
}

double minimum(double[] collection)
{
    double min = collection[0];
    for (int j = 0, arraySize = collection.Length; j < arraySize; j++)
    {
        if (collection[j] < min) min = collection[j];
    }
    return min;
}

double maximum(double[] col)
{
    double max = col[0];
    for (int k = 0, arrayLength = col.Length; k < arrayLength; k++)
    {
        if (col[k] > max) max = col[k];
    }
    return max;
}

double[] array = new double[9];
FillArray(array);
Console.WriteLine($"Array: [ {String.Join("| ", array)} ]");
Console.WriteLine($"Разница между максимальным и минимальным значениями массива = {maximum(array) - minimum(array)}");
