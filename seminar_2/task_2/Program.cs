/* **Задача 12:** 
Напишите программу, которая будет принимать на вход два 
числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу
первому, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4  -> кратно
*/

using static System.Console;

WriteLine("Введите первое число: ");
int FirstNumber = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int SecondNumber = int.Parse(ReadLine()!);

/* Вариант решения №1

if (FirstNumber % SecondNumber == 0)

{
    WriteLine("Кратно");
}

else

{
    WriteLine($"Остаток от деления числа {FirstNumber} на число {SecondNumber} = {FirstNumber % SecondNumber}");
    WriteLine("Остаток от деления числа {0} на число {1} = {2}", FirstNumber, SecondNumber, FirstNumber % SecondNumber);
    WriteLine("Остаток от деления числа" + FirstNumber + "на число" + SecondNumber + " = " + FirstNumber % SecondNumber);
}*/

//Вариант решения №2. Тернарная операция.

WriteLine(FirstNumber % SecondNumber == 0 ? "кратное" : "Остаток от деления числа {0} на число {1} = {2}", FirstNumber, SecondNumber, FirstNumber % SecondNumber);
