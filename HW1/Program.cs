// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine()); // Конвертируем введенные пользователем символы в числовой формат
Console.WriteLine("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2)
{
    Console.WriteLine(Number1 + " больше " + Number2);
}
else if (Number1 < Number2)
{
    Console.WriteLine(Number2 + " больше " + Number1);
}
else
{
    Console.WriteLine("Числа равны");
} 

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine()); // Конвертируем введенные пользователем символы в числовой формат
Console.WriteLine("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int Num3 = Convert.ToInt32(Console.ReadLine());

int max = Num1;

if (Num2 > max) max = Num2;
if (Num3 > max) max = Num3;

Console.WriteLine("Число " + max + " максимальное");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine()); // Конвертируем введенные пользователем символы в числовой формат

if (Number % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine()); // Конвертируем введенные пользователем символы в числовой формат

if (Num < 2)
{
    Console.WriteLine("От 0 до " + Num + " нет чётных чисел.");
}
else
{
    int Count = 2;
    
    while (Num >= Count)
    {
        Console.Write(Count + ", ");
        Count += 2;
    }
}
Console.WriteLine();