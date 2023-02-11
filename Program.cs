// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetArray(10, 100, 999); // (Кол-во элементов, минимальное и максимальное значения массива)
Console.WriteLine(String.Join(" ", array));
int[] GetArray(int size, int minValue, int maxValue) // Метод
{
    int[] res = new int[size]; // Выделение места под новый массив (создание нового массива определенного размера)
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

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetArray(6, 0, 99); // (Кол-во элементов, минимальное и максимальное значения массива)
Console.WriteLine(String.Join(" ", array));
int[] GetArray(int size, int minValue, int maxValue) // Метод
{
    int[] res = new int[size]; // Выделение места под новый массив (создание нового массива определенного размера)
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum = sum + array[i];    
}
Console.Write($"Сумма элементов, cтоящих на нечётных позициях {sum}");

// Задача 38 (вариант 1 "Максимально ужатый". По методу преподавателя Габиля Асланова). 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = GetArray(6, 0, 99); // (Кол-во элементов, минимальное и максимальное значения массива)
Console.WriteLine(String.Join(" ", array));
double[] GetArray(int size, double minValue, double maxValue) // Метод
{
    double[] res = new double[size]; // Выделение места под новый массив (создание нового массива определенного размера)
    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToDouble(new Random().Next(1000,100000)) / 1000; // Три цифры после запятой
    }
    return res;
}
double max = array[0];
double min = array[0];
foreach (double i in array)  // Поиск максимального и минимального значения
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"Разница между максимальным и минимальным значениями {max - min}");

// Задача 38 (вариант 2 "Полный". Задаем размер (длину) массива вручную). 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomNumbers(array);
Console.Write("Массив: ");
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;
foreach (double x in array)  // Поиск максимального и минимального значения
{
    if (min > x) min = x;
    if (max < x) max = x;
}
Console.WriteLine($"Всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
             array[i] = Convert.ToDouble(new Random().Next(100,10000)) / 100; // Два знака после запятой
        }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
