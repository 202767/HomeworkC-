// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] Create2dRandomDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);

    return array;
}

void Show2dArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] / 10 == 0) Console.Write(array[i, j] + "  ");
            else Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2dRandomDoubleArray(rows, columns, minValue, maxValue);
Show2dArrayDouble(myArray);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
bool GetElementAccordIndex(int[,] array, int row, int column)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == row && j == column) return true;

    return false;
}

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);

Console.Write("Input your row: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your column: ");
int userColumn = Convert.ToInt32(Console.ReadLine());
bool result = GetElementAccordIndex(myArray, userRow, userColumn);
if (result == true) Console.WriteLine(myArray[userRow, userColumn]);
else Console.WriteLine("There is no element with such index ");
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] Create2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            Console.Write("Input an element of array: ");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void GetColumnsArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int columnSum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            columnSum += array[i, j];

        double columnArithmeticMean = Math.Round((Convert.ToDouble(columnSum) / array.GetLength(0)), 2);
        Console.Write($"{columnArithmeticMean} ");

    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(rows, columns);
Show2dArray(myArray);
GetColumnsArithmeticMean(myArray);
*/
