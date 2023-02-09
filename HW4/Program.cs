// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation(int A, int B) 
{ 
    int result = 1; 
    for (int i=1; i<=B; i++) 
    { 
        result *= A; 
    } 
    return result; 
} 

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"Итоговый результат: \n{Exponentiation(A, B)}"); 


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int summary(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в этом числе равна {summary(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray() 
{ 
    int[] arr = new int[8]; 
    Random r = new Random(); 

    for (int i=0; i<arr.Length; i++) 
    { 
        arr[i] = r.Next(0, 100); 
    } 

    return arr; 
} 

void PrintArray(int[] arr) 
{ 
    for (int i=0; i<arr.Length; i++) 
    { 
        Console.Write($"{arr[i]} ");
    } 
} 

PrintArray(CreateRandomArray());