// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа
/*
int ShowHundrets(int number)
{
    int hundrets = (number % 100 - number % 10) / 10;
    return hundrets;
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ShowHundrets(number);
Console.WriteLine($"The amount of hundrets {number} is {result}");
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
/*
int ShowThousands(int num)
{
    string numStr = Convert.ToString(num);
    int length = numStr.Length;
    if (length >= 3)
    {
        int thousands = (num % 1000 - num % 100) / 100;
        return thousands;
    }
    else
    {
        int thousands = -1;
        return thousands;
    }
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ShowThousands(number);
if (result == -1)
{
    Console.WriteLine("There is not third figure");
}
else Console.WriteLine($"The amount of thousands in {number} is {result}");
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
/*
bool IsWeekends(int num)
{
    if (num == 6 || num == 7) return true;
    else return false;
}

Console.Write("Input the number of day: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsWeekends(dayNum));
*/