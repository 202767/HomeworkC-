// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт большее число.
/*
// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num2 > num1) Console.WriteLine("max = " + num2);
// else Console.WriteLine("max = " + num1);
*/
// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 & num1 > num3) Console.WriteLine(num1);
if (num2 > num1 & num2 > num3) Console.WriteLine(num2);
if (num3 > num1 & num3 > num2) Console.WriteLine(num3);
*/
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли 
// число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("да");
else Console.WriteLine("нет");
*/
// Задача 8: Напишите программу, которая на вход принимает число (number), 
// а на выходе показывает все чётные числа от 1 до number.
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= number)
{
    if (current % 2 == 0) Console.Write(current + " ");
    current++;
}
*/
