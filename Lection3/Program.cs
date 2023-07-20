// Type 1
/*
void Method1()
{
    Console.WriteLine("Author is ...");
}

Method1();
*/

// Type 2
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Text of message");
*/
/*
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "Text", count: 3);
*/
// Type 3
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

// Type 4
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "adbls");
Console.WriteLine(res);
*/
// Cycle FOR
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;   
    }
    return result;
}

string res = Method4(10, "adbls");
Console.WriteLine(res);
*/
// Table of multiplication
/*
for (int i = 2; i <= 10; i++)
{
  for (int j = 2; j <= 10; j++)
  {
    Console.WriteLine($"{i} * {j} = {i * j}");
  }  
  Console.WriteLine();
}
*/
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить на большие буквы "К",
// большие буквы "С" заменить на маленькие "с".\
/*
string text = " - Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде,"    
            + "вы бы взяли приступом согласие прусского короля. "    
            + "Вы так красноречивы. Сами дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    } 
    return result;
} 

string newText1 = Replace(text, ' ', '|');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = Replace(newText1, 'к', 'К');
Console.WriteLine(newText2);
Console.WriteLine();
string newText3 = Replace(newText2, 'С', 'с');
Console.WriteLine(newText3);
Console.WriteLine();
*/
// Сортировка массива
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
