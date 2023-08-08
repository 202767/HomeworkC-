// Task1. Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}
ShowNums(5);
*/
// Task2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int ShowSumOfDigits(int num)
{
    if (num != 0) return ShowSumOfDigits(num / 10) + num % 10;
    return 0;
}

Console.WriteLine(ShowSumOfDigits(1234));
*/
// Task3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        ShowNumbers(num1, num2 + 1);
        Console.Write(num2 + " ");
    }
    else if (num2 > num1)
    {
        ShowNumbers(num1, num2 - 1);
        Console.Write(num2 + " ");
    }
    else Console.Write(num2 + " ");
}

Console.Write("Input N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input M: ");
int num2 = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num1, num2);
*/
// Task 4. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double Exponentiate(double basis, int power)
{
    if (power > 0) return Exponentiate(basis, power - 1) * basis;
    else if (power < 0) return Exponentiate(basis, power + 1) / basis;
    else return 1;
}

Console.Write("Input a basis: ");
double basis = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a power: ");
int power = Convert.ToInt32(Console.ReadLine());
double result = Math.Round(Exponentiate(basis, power), 2);
Console.Write(result);
*/