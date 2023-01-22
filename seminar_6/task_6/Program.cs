/*
Задача 44. Не используя рекурсию введите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Например: 1) Если N=5 -> 0 1 1 2 3; Если N=3 -> 0 1 1; Если N=7 -> 0 1 1 2 3 5 8
*/

using static System.Console;
Clear();

int num = AskUserForNumber("Введите число для разложения в ряд Фибоначи: ");
PrintArray(Fibonacci(num));

int[] Fibonacci(int inNum)
{
    int[] result = new int[inNum];
    result[0] = 0;
    result[1] = 1;

    for (int i = 2; i < inNum; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
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

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}