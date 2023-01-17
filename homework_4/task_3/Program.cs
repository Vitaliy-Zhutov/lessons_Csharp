/*
Задача 29: Напишите программу, реализующую метод, который формирует массив случайных целых чисел 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]
*/

using static System.Console;
Clear();

int[] arrey = IntArrey();
PrintArrey(arrey);


int[] IntArrey()
{
    int[] res = new int[8];

    for (int i = 0; i < res.Length; i++)
    {
        Random ran = new Random();
        res [i] = ran.Next(0, 99);
    }

    return res;
}

void PrintArrey(int[] arr)
{
    int count = arr.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    
    Console.WriteLine();
}
