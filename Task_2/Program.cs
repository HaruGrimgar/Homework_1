/* 
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

   2, 3, 7 -> 7 
*/

Console.Write("Введите первое число > ");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

Console.Write("Введите второе число > ");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if (b > a) a = b; // используем а, как хранилище максимального элемента

Console.Write("Введите третье число > ");
string number3 = Console.ReadLine();
int c = Convert.ToInt32(number3);

if (c > a) a = c;

Console.WriteLine($"max = {a}");