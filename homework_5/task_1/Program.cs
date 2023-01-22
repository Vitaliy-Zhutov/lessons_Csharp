/*
Задача 34: Напишите программу реализующую методы формирования массива, 
заполненного случайными положительными трёхзначными числами, 
и подсчета количества чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

using static System.Console;
Clear();

WriteLine("Enter the size of the array");
int size = int.Parse(ReadLine()!);
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
WriteLine("Our array: ");
PrintArray(numbers);


int count = 0;
for (int j = 0; j < numbers.Length; j++)
    if (numbers[j] % 2 == 0)
        count++;


WriteLine($"All {numbers.Length} numbers, {count} even numbers");


void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}


void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    WriteLine($"{inArray[inArray.Length - 1]}]");
}
