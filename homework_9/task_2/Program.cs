/*
Задача 66. Напишите программу, которая реализует рекурсивный метод 
нахождения суммы натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using static System.Console;
Clear();

Write("Введите число M: ");
int m = int.Parse(ReadLine()!);

Write("Введите число N: ");
int n = int.Parse(ReadLine()!);

SumFromMToN(m, n);


void SumFromMToN(int m, int n)
{
    Write($"Сумма элементов в промежутке от M до N = {SumMN(m - 1, n)}");
}


int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}