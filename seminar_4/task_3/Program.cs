// Напишите программу которая на вход принимает число N 
// Выдает же произведение чесел от 1 до N
// 4 -> 24
// 5 -> 120

using static System.Console;

Write("Input number: ");
int number = int.Parse(ReadLine()!);

int sum = GetSum(number);

WriteLine($"Sum number 1..N = {sum}");

int GetSum (int N)
{
    int resultSum = 1;

    while (N > 0)
    {
        resultSum *= N;
        N--;
    }

    return resultSum;
}
