/*
Задача 36: Напишите программу реализующую методы формирования массива, 
заполненного случайными числами и подсчета суммы элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using static System.Console;
Clear();

WriteLine("Enter the size of the array");
int size = int.Parse(ReadLine()!);
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
WriteLine("Our array: ");
PrintArray(numbers);


int sum = 0;
for (int j = 0; j < numbers.Length; j += 2)
    sum = sum + numbers[j];


WriteLine($"All {numbers.Length} numbers, the sum of the numbers in odd positions = {sum}");


void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
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
