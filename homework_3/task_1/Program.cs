/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

using static System.Console;
Clear();

Write("Введите 5-ти значное число: ");
string number = Console.ReadLine()!;
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        WriteLine($"{number} - Палиндром");
    }
    else
    {
        WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
