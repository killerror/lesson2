/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


Console.Write("Введите трехзначное число: ");
var str = Console.ReadLine();

if (!int.TryParse(str, out int num))
{
    Console.WriteLine($"{str} не является числом");
    return;
};

num = Math.Abs(num);
if ((num < 100)||(num>999))
{
    Console.WriteLine($"{str} не трехзначное число");
    return;
}

Console.WriteLine($"Вторая цифра числа {str}: {num.ToString()[1]}");