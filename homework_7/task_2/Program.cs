/*
Задача 50. Напишите программу реализующую метод, принимающий позиции элемента в двумерном массиве, 
и возвращающий значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1;7 -> такого элемента в массиве нет
1;1 -> 9
*/

using static System.Console;
Clear();

int rows = ReadInt("Enter the row index: ");
int colums = ReadInt("Enter the column index: ");

int[,] numbers = new int[3, 4];

GetMatrixArra(numbers);
WriteLine();
PrintMatrixArray(numbers);


if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> there is no such number in the array");


int ReadInt(string message)
{
    Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void GetMatrixArra(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5} "); // вывод в 5 символов
        }
        WriteLine();
    }
}
