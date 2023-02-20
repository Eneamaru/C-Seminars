// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.WriteLine("Введите числа через пробел: ");
int[] numbers = Array.ConvertAll(System.Console.ReadLine().Split(), int.Parse);

int Positive(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            count++;
    }
    return count;
}

System.Console.WriteLine($"{Positive(numbers)} чисел больше нуля");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

System.Console.Write("Задайте значение b1: ");
double b1 = int.Parse(Console.ReadLine());
System.Console.Write("Задайте значение b2: ");
double b2 = int.Parse(Console.ReadLine());
System.Console.Write("Задайте значение k1: ");
double k1 = int.Parse(Console.ReadLine());
System.Console.Write("Задайте значение k2: ");
double k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

if ((y != k1 * x + b1) || (k1 - k2 == 0))
{
    System.Console.WriteLine("Решения нет");
}
else
{
    System.Console.WriteLine($"Две прямые пересекутся по данным координатам: ({x}); ({y})");
}


// Задача 44: Выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int Fibonacci(int n)
{
    int a = 0, b = 1, c;
    if (n == 0)
        return a;
    System.Console.Write(a + " " + b + " ");
    for (int i = 2; i <= n; i++)
    {
        c = a + b;
        a = b;
        b = c;
        System.Console.Write(b + " ");
    }
    return b;
}

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Fibonacci(n);