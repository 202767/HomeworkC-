// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void ScoreAmountOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    Console.WriteLine($"There is(are) {count} positive number(s) ");
    Console.WriteLine();
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

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

Console.Write("Input amount of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);
ScoreAmountOfPositiveNumbers(myArray);
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void ShowIntersectionPoint(int k1, int b1, int k2, int b2)
{
    if (k1 == k2)
    {
        if (b1 == b2) Console.WriteLine("Lines coincide ");
        else Console.WriteLine("Lines are parallel");
    }
    else
    {
        double X = (b2 - b1) / (k1 - k2);
        double Y = k1 * X + b1;
        Console.WriteLine($"The intersection point is ({X},{Y})");
    }
}

Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

ShowIntersectionPoint(k1, b1, k2, b2);

