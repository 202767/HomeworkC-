// Task1. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)
/*
void ShowDiapozone(int quad)
{
    if (quad == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quad == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quad == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quad == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");
}

Console.Write("Input a number of quadrant(from 1 to 4): ");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowDiapozone(quadrant);
*/
// Task2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.
/*
void ShowQuadrant(double X, double Y)
{
    if (X > 0 && Y > 0) Console.WriteLine("1st quadrant ");
    else if (X < 0 && Y > 0) Console.WriteLine("2nd quadrant ");
    else if (X < 0 && Y < 0) Console.WriteLine("3rd quadrant ");
    else if (X > 0 && Y < 0) Console.WriteLine("4th quadrant ");
    else Console.WriteLine("Wrong input!");
}

Console.Write("Input X: ");
double x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y: ");
double y = Convert.ToInt32(Console.ReadLine());

ShowQuadrant(x, y);
*/
// Task3. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
/*
Double ShowDistance(double x1, double y1, double x2, double y2)
{
    double cathet1square = (x2 - x1) * (x2 - x1);
    double cathet2square = (y2 - y1) * (y2 - y1);
    double hypotenuse = Math.Sqrt(cathet1square + cathet2square);
    return hypotenuse;

}

Console.Write("Input x1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(ShowDistance(X1, Y1, X2, Y2));
*/
// Task4. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
/*
void TableOfSquares(int num)
{
    int index = 1;
    while (num >= index)
    {
        Console.WriteLine(index + " " + index * index);
        index++;
    }
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

TableOfSquares(number);
*/