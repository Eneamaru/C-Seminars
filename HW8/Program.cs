Console.Clear();

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

int[,] matr1 = GenerateIntMatrix(4, 4, -10, 10);

void PrintIntMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            System.Console.Write(array[i, l] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void MatrixSort(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[row, i] < array[row, j])
                {
                    int temp = array[row, i];
                    array[row, i] = array[row, j];
                    array[row, j] = temp;
                }
            }
        }
    }
}

PrintIntMatrix(matr1);
MatrixSort(matr1);
PrintIntMatrix(matr1);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int FindSmallestRow(int[,] array)
{
    int minRowIndex = 0;
    int minRowSum = int.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currRowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            currRowSum += array[i, j];
        }

        if (currRowSum < minRowSum)
        {
            minRowIndex = i;
            minRowSum = currRowSum;
        }
    }

    return minRowIndex;
}

System.Console.WriteLine($"Строка с наименьшей суммой элементов - {FindSmallestRow(matr1) + 1}\n");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matr2 = GenerateIntMatrix(4, 4, -10, 10);

PrintIntMatrix(matr1);
PrintIntMatrix(matr2);

int[,] MultiplyMatrixes(int[,] matrix1, int[,] matrix2)
{
    int row1 = matrix1.GetLength(0);
    int col1 = matrix1.GetLength(1);
    int row2 = matrix2.GetLength(0);
    int col2 = matrix2.GetLength(1);

    if (col1 != row2)
    {
        System.Console.WriteLine("Эти матрицы нельзя перемоножить\n");
    }

    int[,] resultMatrix = new int[row1, col2];

    for (int i = 0; i < row1; ++i)
    {
        for (int j = 0; j < col2; ++j)
        {
            int product = 0;
            for (int k = 0; k < col1; ++k)
            {
                product += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = product;
        }
    }
    return resultMatrix;
}

int[,] matrProduct = MultiplyMatrixes(matr1, matr2);

PrintIntMatrix(matrProduct);


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] Generate3DArray()
{
    int[,,] threeDArray = new int[2, 2, 2];

    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 2; y++)
        {
            for (int z = 0; z < 2; z++)
            {
                threeDArray[x, y, z] = new Random().Next(10, 100);
            }
        }
    }
    return threeDArray;
}

int[,,] matr3 = Generate3DArray();

void Print3DIndexedArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
        }
    }
}

Print3DIndexedArray(matr3);