// Найти сумму всех чисел от 1 до А.


using static System.Console;

Write("Input number: ");
int number = int.Parse(ReadLine()!);

int sum = GetSum(number);

WriteLine($"Sum number 1..A = {sum}");


int GetSum(int A)
{
    int resultSum = 0;
    while (A > 0)
    {
        resultSum += A;
        // resultSum = resultSum + A
        A--;
        // A = A - 1 
    }
    return resultSum;
}
