﻿/* Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8
*/

Console.Write("Введите число N -> ");
string number1 = Console.ReadLine();
int N = Convert.ToInt32(number1);

Console.WriteLine("Ряд чётных чисел от 1 до N :");
Console.Write($"{N} -> ");
int i = 2;
while (i <= N)
{
    Console.Write(i + " ");
    i = i + 2;
}

