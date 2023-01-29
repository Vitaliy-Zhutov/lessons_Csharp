/* 
Напишите программу реализующую метод, который возвращает массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

using static System.Console;
Clear();

int rows = ReadInt("Enter the number of rows: ");
int colums = ReadInt("Enter the number of columns: ");

double[,] numbers = new double[rows, colums];

GetMatrixArra(numbers);
WriteLine();
PrintMatrixArray(numbers);



int ReadInt(string message)
{
    Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void GetMatrixArra(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}


void PrintMatrixArray(double[,] inArray)
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
