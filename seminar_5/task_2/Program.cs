/* 
Задача 32. Напишите программу для заменны элементов массива.
Положительные элементы заменяются на соответствующие отрицательные
и на оборот.
Например: [-4, -8, 8, 2] [4, 8, -8, -2]
*/

using static System.Console;
Clear();


int[] arrey = { -1, -2, 0, 2, 1, 3, 4 };


ReverseArrey(arrey);
PrintArray(arrey);


void ReverseArrey(int[] inArrey)
{
    for(int i = 0; i < inArrey.Length; i++)
    {
        inArrey[i] *= -1;   
    }
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
