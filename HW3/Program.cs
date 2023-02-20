// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num;
int.TryParse(Console.ReadLine(), out num);
int temp = num;

int rev = 0;

while (temp > 0)
{
    rev = rev * 10 + temp % 10;
    temp = temp / 10;
}

if (num == rev)
    Console.WriteLine("Это палиндром");
else
    Console.WriteLine("Это не палиндром");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки A по оси x");
double xA = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки A по оси y");
double yA = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки A по оси z");
double zA = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси x");
double xB = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси y");
double yB = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси z");
double zB = double.Parse(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2)));


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    double cube = Math.Pow(i, 3);
    Console.WriteLine(i + "\t" + cube);
}