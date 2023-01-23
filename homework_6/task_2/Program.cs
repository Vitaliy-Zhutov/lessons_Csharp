/* 
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

using static System.Console;
Clear();


Write("Enter number b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Write("Enter number k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Write("Enter number b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Write("Enter number k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


if (k1 == k2 && b1 == b2)
{
    WriteLine("Lines not overlap");
}
else if (k1 == k2)
{
    WriteLine("Lines parallel");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    WriteLine($"Intersection point: x={x}, y={y}");
}
