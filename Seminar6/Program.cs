// Task1. Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
void ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temporary = array[i];
        array[i] = array[j];
        array[j] = temporary;
    }
}

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

Console.Write("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/
// Task2. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
/*
int[] CreateArray()
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Input a {i + 1} side: ");
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

bool IsTriangle(int[] array)
{
    for (int i = 0; i < 1; i++)
        if (array[i] + array[i + 1] > array[i + 2]) return true;

    return false;
}

int[] myArray = CreateArray();
ShowArray(myArray);
Console.WriteLine(IsTriangle(myArray));
*/
// Task3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
/*
int[] CreateArrayOfFibonacciNumbers(int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input the amount of Fibonacci numbers: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArrayOfFibonacciNumbers(number);
ShowArray(myArray);
*/
// Task4. Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.
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

int[] CopyArray(int[] array)
{
    int[] arrayCopied = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        arrayCopied[i] = array[i];
    return arrayCopied;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int[] copiedArray = CopyArray(myArray);
myArray[0] = 0;
ShowArray(myArray);
ShowArray(copiedArray);
*/
