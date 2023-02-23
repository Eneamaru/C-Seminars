void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

void PrintIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GenerateDoubleMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().NextDouble() * 10;
        }
    }
    return matrix;
}

double[,] matrix = GenerateDoubleMatrix(3, 4, -10, 10);
PrintDoubleMatrix(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GenerateIntMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] matr = GenerateIntMatrix(4, 4, 0, 100);

System.Console.WriteLine();
PrintIntMatrix(matr);

int GetElementValueFrom2DArray(int[,] array, int row, int column)
{
    System.Console.WriteLine();
    if (row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(1))
    {
        System.Console.WriteLine("Такого элемента не существует.");
        return -1;
    }
    else
    {
        int value = array[row, column];
        System.Console.WriteLine("Значение элемента: " + value);
        return value;
    }
}

GetElementValueFrom2DArray(matr, 2, 2); // Элемент в массиве
GetElementValueFrom2DArray(matr, 5, 5); // Элемента по дааным координатам в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void ArithmeticMean(int[,] arr)
{
    int cols = arr.GetLength(1);
    int rows = arr.GetLength(0);

    double sum = 0;
    int elementsCount = 0;

    for (int c = 0; c < cols; c++)
    {
        for (int r = 0; r < rows; r++)
        {
            sum += arr[r, c];
            elementsCount++;
        }
        System.Console.WriteLine();
        System.Console.Write($"Среднее арифметическое: ");
        System.Console.Write($"{sum / rows,1} ");
    }
    System.Console.WriteLine();
}

ArithmeticMean(matr);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralFillArray(int[,] arr)
{
    int rowLength = arr.GetLength(0);
    int colLength = arr.GetLength(1);
    int minRow = 0; int maxRow = rowLength - 1;
    int minCol = 0; int maxCol = colLength - 1;
    int counter = 1;
    while (minRow <= maxRow && minCol <= maxCol)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            arr[minRow, i] = counter++;
        }
        for (int j = minRow + 1; j <= maxRow; j++)
        {
            arr[j, maxCol] = counter++;
        }
        for (int i = maxCol - 1; i >= minCol; i--)
        {
            arr[maxRow, i] = counter++;
        }
        for (int j = maxRow - 1; j >= minRow + 1; j--)
        {
            arr[j, minCol] = counter++;
        }
        minRow++;
        minCol++;
        maxRow--;
        maxCol--;
    }
    return arr;
}

System.Console.WriteLine();
PrintIntMatrix(SpiralFillArray(matr));
