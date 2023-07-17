// Task19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
/*
void IsPalindrome(int num)
{
    if (num / 10000 == 0) Console.WriteLine("Wrong input! ");
    else if (num / 10000 == num % 10 &&
    (num % 10000 - num % 1000) / 1000 == (num % 100 - num % 10) / 10) Console.WriteLine($"{num} is palindrome ");
    else Console.WriteLine($"{num} is not palindrome ");
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

IsPalindrome(number);
*/
// Task21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double ShowDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distanceXYsquare = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
    double distanceXYZ = Math.Sqrt((z2 - z1) * (z2 - z1) + distanceXYsquare);
    return distanceXYZ;
}

Console.Write("Input X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z2: ");
double Z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(ShowDistance(X1, Y1, Z1, X2, Y2, Z2), 2));
*/
// Task23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void TableOfCubes(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index} - {index * index * index}");
        index++;
    }
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) Console.WriteLine("Wrong input!");
else TableOfCubes(number);
*/