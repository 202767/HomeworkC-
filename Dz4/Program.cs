// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
/*
int Exponentiation(int num, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result = result * num;
    }
    return result;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input power: ");
int power = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(number, power);
Console.WriteLine(result);
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfFigures(int num)
{
    int sum = 0;
    while (num / 10 > 0)
    {
        if (num % 10 == 0)
            num = num / 10;
        if (num % 10 > 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
    }
    if (num / 10 == 0) sum = sum + num;
    return sum;
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfFigures(number));
*/
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. 
// Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input a number: ");
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
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
*/