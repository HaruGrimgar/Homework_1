/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

    a = 5; b = 7 -> max = 7 */

Console.Write("Введите первое число > ");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

Console.Write("Введите второе число > ");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if (a >= b)
{
    Console.WriteLine($"max = {a}, min = {b}");
}
else
{
    Console.WriteLine($"max = {b}, min = {a}");
}
