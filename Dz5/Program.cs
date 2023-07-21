// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray3(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1001);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int GetAmountOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray3(size);
ShowArray(myArray);

int amountOfEven = GetAmountOfEvenNumbers(myArray);
if (amountOfEven == 0) Console.WriteLine("There are no even numbers ");
else Console.WriteLine(amountOfEven);
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next();
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int GetSumOfOddPositionNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        if (i % 2 == 0) sum += array[i];
    }
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size);
ShowArray(myArray);

int sumOfOddPositionNumbers = GetSumOfOddPositionNumbers(myArray);
Console.WriteLine($"The sum of odd position numbers is {sumOfOddPositionNumbers}");
*/
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateArrayDouble(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i} number: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double DiffMaxAndMin(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue) minValue = array[i];
        if (array[i] > maxValue) maxValue = array[i];
    }
    double sum = maxValue - minValue;
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArrayDouble(size);
ShowArrayDouble(myArray);

double difference = DiffMaxAndMin(myArray);
Console.WriteLine($"The difference of max and min values is {difference}");
*/