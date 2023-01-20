/* 
Задача 33. Напишите программу, которая определяет,
присутствует ли заданное числое в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int[] array = { -1, -2, 0, 2, 1, 3, 4 };

WriteLine(ArreyLookUp(array, number) ? "да" : "нет");

bool ArreyLookUp(int[] inArray, int num)
{
    foreach (int i in inArray)
    {
        if (num == i) return true;
    }
    return false;
}
