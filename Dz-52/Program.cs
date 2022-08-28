// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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


void newArray(int[,] myArray)
{
    double result = 0;

    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            result += myArray[i,j];
        }
        result /= myArray.GetLength(0);
        Console.Write($"{result:N2}; ");
    }
    return;
}

Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(a, b, 0, 100);
PrintArray(myArray);
Console.WriteLine();
newArray(myArray);

