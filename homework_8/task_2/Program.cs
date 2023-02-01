/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка.
*/

using static System.Console;
Clear();

Write("Введите размер матрицы (строки, столцы) и диапазон значений (1..9) через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));

PrintMatrixArray(array);


int minSumLine = 0;
int sumLine = SumLineIndex(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{   int tempSumLine = SumLineIndex(array, i);;
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой = {sumLine}");


int SumLineIndex(int[,] array, int i)

{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rand = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return resultArray;
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");
        }
        WriteLine();
    }
}