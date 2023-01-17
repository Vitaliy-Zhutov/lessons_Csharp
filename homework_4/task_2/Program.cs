/*
Задача 27: Напишите программу, реализующую метод, который принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using static System.Console;
Clear();

int number = ImputNumber("Imput number: ");
int len = NumberLen(number);
SumNumbers(number, len);


// Функция ввода
int ImputNumber(string message)
{
    Console.Write(message);
    return int.Parse(ReadLine()!);
}

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a != 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Sum of digits = {sum}");
}

