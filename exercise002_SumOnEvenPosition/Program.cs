// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] collection)
{
    for (int i = 0, arraySize = collection.Length; i < arraySize; i++)
    {
        collection[i] = new Random().Next(-100, 101);
    }
}

int notEvenSum = 0;
int[] array = new int[9];
FillArray(array);
Console.WriteLine($"Array: [ {String.Join(", ", array)} ]");

for (int i = 0, arraySize = array.Length; i < arraySize; i++)
{
    if (i % 2 != 0) notEvenSum = notEvenSum + array[i];
}
Console.WriteLine($"Сумма элемнтов, стоящих на нечетных позициях = {notEvenSum}");