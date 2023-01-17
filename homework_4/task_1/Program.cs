/*
Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B с использованием цикла.
В задаче не использвать стандартный метод Pow!
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using static System.Console;
Clear();

Write("Input first number: ");
int FirstNumber = int.Parse(ReadLine()!);

Write("Input second number (Degree): ");
int SecondNumber = int.Parse(ReadLine()!);

DegreeNumber(FirstNumber, SecondNumber);

// Функция возведения в степень
void DegreeNumber(int a, int b)
{
    int result = 1;

    for (int i = 0; i < b; i++)
    {
        result *= a;
    }

    Console.WriteLine($"Number {FirstNumber} in degrees {SecondNumber} = {result}");
}
