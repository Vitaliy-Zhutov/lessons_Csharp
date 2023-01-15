// Напишите программу, которая выводит массив из 8 элементов
// заполненный нулями и единицами в случайном порядке.

using static System.Console;
Clear();


int[] arrey = IntBinaryArrey();
PrintArrey(arrey);


int[] IntBinaryArrey()
{
    int[] res = new int[8];

    for (int i = 0; i < res.Length; i++)
    {
        Random ran = new Random();
        res [i] = ran.Next(0, 2);
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