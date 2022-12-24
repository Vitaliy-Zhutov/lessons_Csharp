//   Два стрелка
//  На вход - сколько банок каждый стрелок сбил
//  /*
//  На выход - сколько всего банок было
//  */
//  В последнюю попали одновременно.

// Задача непонятно зачем =)

using static System.Console;

Write("Input first number: ");
int FirstNumber = int.Parse(ReadLine()!);
Write("Input second number: ");
int SecondNumber = int.Parse(ReadLine()!);

int Result = FirstNumber + SecondNumber - 1;
WriteLine(Result);
