// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNums(num - 1);
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNums(number);
*/
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int ShowSum(int num1, int num2, int sum)
{
    if (num1 > num2) return ShowSum(num1, num2 + 1, sum + num2);
    else if (num1 < num2) return ShowSum(num1 + 1, num2, sum + num1);
    else return sum + num2;
}

int sum = 0;
Console.Write("Input M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = ShowSum(num1, num2, sum);
Console.WriteLine(result);
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunction(m, n);
Console.WriteLine(result);
*/