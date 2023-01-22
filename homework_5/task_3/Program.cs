/*
Задача 38: Напишите программу реализующую методы формирования массива, 
заполненного случайными вещественными числами и вычисления разницы 
между максимальным и минимальным элементов массива.
[3,3 7,1 22,5 2,2 78,2] -> 76
*/

using static System.Console;
Clear();


WriteLine("Enter the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];


FillArrayRandomNumbers(numbers);
WriteLine("Our array: ");
PrintArray(numbers);


double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > max)
    {
        max = numbers[j];
    }

    if (numbers[j] < min)
    {
        min = numbers[j];
    }
}

WriteLine($"Difference between max and min value = {max - min}");


void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}


void PrintArray(double[] numbers)
{
    Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Write(numbers[i] + " ");
    }
    Write("]");
    WriteLine();
}
