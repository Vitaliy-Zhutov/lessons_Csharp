/*
Задача 64: Напишите программу, которая реализует рекурсивный метод вывода 
всех натуральных числел в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);
int count = 1;
NaturalNumbers(number, count);

void NaturalNumbers(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalNumbers(n, count + 1);
        Write(count + " ");
    }
}
