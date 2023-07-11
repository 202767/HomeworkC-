// Task1. Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
/*
int CutNumber(int num)
{
    int hundrets = num / 100;
    int units = num % 10;

    int result = hundrets * 10 + units;
    return result;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/
// Task3. Напишите программу, которая на вход принимает число и проверяет,
// кратно ли оно одновременно a и b.
/*
bool IsDividable(int number, int a, int b)
{
    if (number % a == 0 && number % b == 0) return true;
    else return false;
}

Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

bool result = IsDividable(number, div1, div2);
Console.WriteLine(result);
*/
// Task5. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
/*
int MeasureNum(int num)
{
    int hundrets = num / 10;
    int units = num % 10;
    int max = hundrets;
    if (hundrets > units) return max;
    else
    {
        max = units;
        return max;
    }

}

int randNumber = new Random().Next(10, 100);
int maxNumber = MeasureNum(randNumber);

Console.WriteLine($"Max figure of {randNumber} is {maxNumber}");
*/
// Task7. Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
/*
bool IsSquare(int num1, int num2)
{
    if (num1 == num2 * num2 || num2 == num1 * num1) return true;
    else return false;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(num1, num2);
Console.WriteLine(result);
*/
