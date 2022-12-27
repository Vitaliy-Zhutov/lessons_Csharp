/*
Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

using static System.Console;
Clear();

Write("Введите x1:");
if (!int.TryParse(ReadLine(), out int X1))
{
WriteLine("Ошибка, введите число");
return;
}

Write("Введите y1:");
if (!int.TryParse(ReadLine(), out int Y1))
{
WriteLine("Ошибка, введите число");
return;
}

Write("Введите z1:");
if (!int.TryParse(ReadLine(), out int Z1))
{
WriteLine("Ошибка, введите число");
return;
}

Write("Введите x2:");
if (!int.TryParse(ReadLine(), out int X2))
{
WriteLine("Ошибка, введите число");
return;
}

Write("Введите y2:");
if (!int.TryParse(ReadLine(), out int Y2))
{
WriteLine("Ошибка, введите число");
return;
}

Write("Введите z2:");
if (!int.TryParse(ReadLine(), out int Z2))
{
WriteLine("Ошибка, введите число");
return;
}

double Val = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2) + Math.Pow((Z1 - Z2), 2));
WriteLine("Расстояние между 2 точками в 3D равно: {0:f2}", Val);
