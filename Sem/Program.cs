/*
int[] GetArray(int size, int minValue, int maxValue);

    int[] res =  new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, MaxValue + 1);
    }
    return res;

int[] array = GetArray(12, -9, 9);

Console.WriteLine(String.Join(" ", array));

int PositiveSum = 0;
int NegativeSum = 0;

foreach (var el in array)
{
    PositiveSum += el > 0 ? el : 0;
    NegativeSum += el < 0 ? el : 0;
}

Console.WriteLine($"Positive sum = {PositiveSum}, negative sum = {NegativeSum}");
*/

int[] CreateRandomArray() 
{ 
    int[] arr = new int[4]; 
    Random r = new Random(); 

    for (int i=0; i<arr.Length; i++) 
    { 
        arr[i] = r.Next(-100, 100); 
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

int[] Inverse(int[] arr)
{
    int[] array = CreateRandomArray();
    for (int i=0; i<arr.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

PrintArray(Inverse());
/*
int [] SomeElements(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] Massiv = SomeElements (5, 0, 5);

Console.WriteLine(String.Join(" ", Massiv));

System.Console.Write("Введите число: ");
int temp = int.Parse(Console.ReadLine());

bool Yes = false; 

foreach (var i in Massiv)
{
    if (Math.Abs(i) == Math.Abs(temp))
    Yes = true;
}

if (Yes) System.Console.WriteLine("Да!");
else
{
    System.Console.WriteLine("Нет!");
}
*/
