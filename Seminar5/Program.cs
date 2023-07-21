// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных элементов массива.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int GetNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) sum += array[i];

    return sum;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
int negativeSum = GetNegativeSum(myArray);
Console.WriteLine($"Sum of negative's is {negativeSum}");
*/
// Task1. Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] ChangeSignOfElement(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] *= -1;
    return array;
}

Console.Write("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
int[] changedArray = ChangeSignOfElement(myArray);
ShowArray(changedArray);
*/
// Task2. Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

bool IsElementInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num) return true;
    return false;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsElementInArray(myArray, number));
*/
// Task3. Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int GetAmountOfElementsOfArrayInRange(int[] array, int minRangeValue, int maxRangeValue)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minRangeValue && array[i] <= maxRangeValue) count++;
    }
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);

Console.Write("Input a min value of range ");
int minRangeValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value of range ");
int maxRangeValue = Convert.ToInt32(Console.ReadLine());

int count = GetAmountOfElementsOfArrayInRange(myArray, minRangeValue, maxRangeValue);
if (count == 0) Console.WriteLine("There are no such elements");
else Console.WriteLine(count);
*/