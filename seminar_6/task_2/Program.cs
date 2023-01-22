/*
Напишите программу, которая принимает на вход 3 числа
и проверяет, может ли существовать треугольник такой длинны.
*/

using static System.Console;
Clear();

int a = AskUserForNumber("Введите сторону треугольника a: ");
int b = AskUserForNumber("Введите сторону треугольника b: ");
int c = AskUserForNumber("Введите сторону треугольника c: ");

WriteLine(IsTriangle(a, b, c) ? $"Треугольник со сторонами {a}, {b} и {c} существует" : 
$"Треугольник со сторонами {a}, {b} и {c} не существует");


bool IsTriangle(int inA, int inB, int inC)
{
    return (inA + inB > inC && inA + inC > inB && inB + inC > inA);
}


int AskUserForNumber(string inPromot)
{
    int resultNum = 0;
    string userInput = "";
    while (!int.TryParse(userInput, out resultNum))
    {
        Console.Write(inPromot);
        userInput = Console.ReadLine()!;
    }
    return resultNum;
}
