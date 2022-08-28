
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// m = 1, n =7 -> такого числа в массиве нет


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void newArray(int[,] myArr, int c, int d)
{
    if (c < myArr.GetLength(0) && d < myArr.GetLength(1))
    {
        Console.Write($"{myArr[c-1, d-1]}");
    }
    else
    {
        Console.WriteLine("такого числа в массиве нет");
    }
}

Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());

Console.Write("Задайте строку элемента: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте столбец элемента: ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(a, b, -100, 100);
PrintArray(myArray);

newArray(myArray, m, n);

