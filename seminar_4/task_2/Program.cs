// Напишите программу, которая на вход принимает число и выводит
// Количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

using static System.Console;

Write("Input number: ");
int number = int.Parse(ReadLine()!);

int count = numCount(number);

WriteLine($"Number of digits in a number = {count}");


int numCount(int num)
{
    int resultCount = 0;

    while (num > 0)
    {
        num /= 10;
        resultCount++;
    }

    return resultCount;
}
