/*
Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

 4 -> да
 -3 -> нет
 */

Console.Write("Введите число > ");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

if (a % 2 == 0)
{
    Console.WriteLine($"{a} -> чётное число");
}
else
{
    Console.WriteLine($"{a} -> нечётное число");
}

