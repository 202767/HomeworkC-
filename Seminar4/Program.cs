// Task1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int SumNum(int num)
{
    int count = 1;
    int sum = 0;
    while (count <= num)
    {
        sum = sum + count;
        count++;
    }
    return sum;
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of numbers from 1 to {number} is {SumNum(number)}");
*/
// Task2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int ShowAmountOfFigures(int num)
{
    int figure = 1;
    while (num / 10 > 0)
    {
        num = num / 10;
        figure++;
    }
    return figure;
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The amount of figures of {number} is {ShowAmountOfFigures(number)}");
*/
// Task3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int MultNum(int num)
{
    int mult = 1;
    int count = 1;
    while (count <= num)
    {
        mult = mult * count;
        count++;
    }
    return mult;
}
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The multiplication of nums from 1 to {number} is {MultNum(number)}");
*/

// Массивы
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
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

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
*/