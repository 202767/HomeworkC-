/*
// int a = 25;
// double b = 36.6;
// string c = "Hello, World! ";
// bool d = true;

// int number1 = 5;
// int number2 = 7;

// Console.WriteLine("My numbers are " + number1 + " and " + number2 + " and it is good!");
// Console.WriteLine($"My numbers are {number1} and {number2} and it is good!");

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your num is " + num);
*/
// Task1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
/*
// Console.Write("Input a first num: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second num: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2 * num2) Console.WriteLine("Yes");
// else Console.WriteLine("No");
*/
// Task2. Напишите программу, которая на вход принимает одно число(umber),
// а на выход показывает все целые числа в промежутке от -number до number.
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while (current <= number)
{
    Console.Write(current + " ");
    current++;
}