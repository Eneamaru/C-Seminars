// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int Number;
int.TryParse(Console.ReadLine(), out Number);

if (Number < 100 || Number > 999)
{
    Console.WriteLine("Это не трёхзначное число");
}
else
{
    Console.WriteLine((Number / 10) % 10);
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int Num;
int.TryParse(Console.ReadLine(), out Num);

if (Num < 100)
{
    Console.WriteLine("В числе нет третьей цифры");
}
else
{
    while (Num > 999)
    {
        Num /= 10;
    }
    Console.WriteLine($"Третья цифра в числе - {Num % 10}");
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");
int Day;
int.TryParse(Console.ReadLine(), out Day);

switch (Day)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Это не день недели");
        break;
}