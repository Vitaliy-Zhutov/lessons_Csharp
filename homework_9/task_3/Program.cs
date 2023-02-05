/*
Задача 68. Напишите программу реализующую метод вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

using static System.Console;
Clear();

Write("Введите число M: ");
int m = int.Parse(ReadLine()!);

Write("Введите число N: ");
int n = int.Parse(ReadLine()!);

AkkermanFunction(m,n);


void AkkermanFunction(int m, int n)
{
    Write($"Результат = {(Akkerman(m, n))}"); 
}


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    
    else if (n == 0 && m > 0) return Akkerman(m - 1, 1);

    else return (Akkerman(m - 1, Akkerman(m, n - 1)));
    
}
