/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

using static System.Console;
Clear();

Write("Введите 3-х значное число: ");
int Number = int.Parse(ReadLine()!);

int SecondNumber = Number % 100 / 10;

Write("Второе число = {0}", SecondNumber);
