// Метод заполнения массива случайными числами по заданным параметрам
int[] FillArrayWithRandomNumbers(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

// Метод заполнения массива случайными вещественными числами по заданным параметрам
double[] FillArrayWithRandomDoubleNumbers(int size, double min, double max)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble() * (max - min) + min;
    }
    return array;
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] myArr = FillArrayWithRandomNumbers(8, 100, 1000);

int Count = 0;

foreach (int value in myArr)
{
    if (value % 2 == 0)
    {
        Count++;
    }
}
System.Console.WriteLine(String.Join(" | ", myArr));
System.Console.WriteLine($"В массиве {Count} чётных числа(ел).");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] arr = FillArrayWithRandomNumbers(8, -100, 101);

int sum = 0;
for (int i = 0; i < arr.Length; i++) 
{ 
    if (i % 2 == 1) 
    { 
        sum += arr[i]; 
    } 
}
System.Console.WriteLine(String.Join(", ", arr));
System.Console.WriteLine($"Сумма элементов стоящих на нечётных позициях: {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] myArray = FillArrayWithRandomDoubleNumbers(8, -100, 100);

System.Console.WriteLine(String.Join(" | ", myArray));

// Простой способ с использованием методов Min и Max
// System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {myArray.Max() - myArray.Min()}");

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    return max - min;
}
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {Difference(myArray)}");