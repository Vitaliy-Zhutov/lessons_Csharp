/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 6
78 -> третьей цифры нет
32679 -> 6
*/

using static System.Console;
Clear();

Write("Введите число от -2147483648 до 2147483647: ");
int Number = int.Parse(ReadLine()!);

if (Number < 100)

{
    WriteLine("В веденом числе нет третьей цифры");
    return -1;
}

int ThreeNumber = Number % 1000 / 100;
Write("Третья цифра = {0}", ThreeNumber);
return ThreeNumber;
