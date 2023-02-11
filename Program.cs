// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetArray(10, 100, 999); // (Кол-во элементов, минимальное и максимальное значения массива)
Console.WriteLine(String.Join(" ", array));
int[] GetArray(int size, int minValue, int maxValue) // Метод
{
    int[] res = new int[size]; // new int[size] - Выделение места под новый массив (создание нового массива определенного размера)
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    count++;
}
Console.Write($"Четных чисел в массиве {count}");

