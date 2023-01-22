/*
Задача 42. Напишите программу, которая будет проиобразовывать десятичное число,
в двоичное.
*/

using static System.Console;
Clear();

int num = AskUserForNumber("Введите число для перевода в двоичную систему: ");

WriteLine($"Десятичное число - {num}, в двоичном представлении будет - {decimalToBinary (num)}.");


string decimalToBinary (int inNum)
{
    if (inNum == 0) return "0";
    string result = string.Empty;
    // Остаток - remainder -> rem
    int rem;

    while (inNum > 0)
    {
        rem = inNum % 2;
        inNum /= 2;
        result = rem.ToString() + result;
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

