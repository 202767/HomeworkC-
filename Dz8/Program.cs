// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
/*
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

void SortRowsOfArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
        }
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
SortRowsOfArray(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
/*
void FindMinSumRow(int[,] array)
{

    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        sumArray[i] = sum;
    }
    int maxSum = sumArray[0];
    int maxRow = 0;
    for (int k = 0; k < sumArray.Length; k++)
    {
        if (maxSum < sumArray[k])
        {
            maxSum = sumArray[k];
            maxRow = k;
        }
    }
    Console.WriteLine($"{maxRow + 1} row ");

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
FindMinSumRow(myArray);
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
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

int[,] MultiplyMatrices(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array2.GetLength(1); j++)
                for (int k = 0; k < array2.GetLength(0); k++)
                    newArray[i, j] += array1[i, k] * array2[k, j];

    }
    return newArray;
}

Console.Write("Input a number of 1st array's rows: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of 1st array's columns: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of 1st array: ");
int minValue1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of 1st array: ");
int maxValue1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of 2nd array's rows: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of 2nd array's columns: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of 2nd array: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of 2nd array: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = CreateRandom2dArray(rows1, columns1, minValue1, maxValue1);
Show2dArray(array1);
Console.WriteLine();
int[,] array2 = CreateRandom2dArray(rows2, columns2, minValue2, maxValue2);
Show2dArray(array2);
Console.WriteLine();
int[,] multArray = MultiplyMatrices(array1, array2);
Show2dArray(multArray);
*/
// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] Create3dArray(int rows, int columns, int heights)
{
    int[,,] array = new int[rows, columns, heights];
    if (rows * columns * heights < 1000)
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write("Input an element: ");
                    array[i, j, k] = Convert.ToInt32(Console.ReadLine());

                }
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (array[i, j, k] > 10 && array[i, j, k] < 100)
                    Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                else Console.WriteLine("Nan");
        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of heights: ");
int heights = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = Create3dArray(rows, columns, heights);
Show3dArray(myArray);
*/