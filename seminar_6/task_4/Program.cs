/*
Задача. Данн массив из 6 чисел. 
Сумма первых 3х чисел должна равнятся сумме вторых 3х чисел.
*/

using static System.Console;
Clear();

int ticket = AskUserForNumber("Введите номер билета: ");

WriteLine(IsLuckyTicket(ticket) ? $"Билетик {ticket} счастливый" :
$"Билетик {ticket} не счастливый");

bool IsLuckyTicket(int inNum)
{
    int a = inNum / 100000;
    int b = (inNum / 10000) % 10;
    int c = (inNum / 1000) % 10;
    int d = (inNum % 1000) / 100;
    int e = (inNum % 1000) / 10 % 10;
    int f = (inNum % 1000) % 10;
    return (a + b + c == d + e + f);
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
