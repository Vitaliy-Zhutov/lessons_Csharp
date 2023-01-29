/* 
Задача 52. Напишите программу реализующую методы, формирования двумерного массива 
и массива средних арифметических значений каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using static System.Console;
Clear();

int rows = ReadInt("Enter the number of rows: ");
int colums = ReadInt("Enter the number of columns: ");

int[,] numbers = new int[rows, colums];

double[] avgNumbers = new double[numbers.GetLength(1)];

GetMatrixArray(numbers);
WriteLine();
PrintMatrixArray(numbers);


for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    avgNumbers[i] = result / numbers.GetLength(0);
}

WriteLine();
PrintResultArray(avgNumbers);


void GetMatrixArray(int[,] array)
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
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}


void PrintResultArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i],5} ");
    }
    WriteLine();
}


int ReadInt(string message)
{
    Write(message);
    return Convert.ToInt32(ReadLine());
}