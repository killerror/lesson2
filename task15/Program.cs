/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели: ");
var str = Console.ReadLine();

if (!int.TryParse(str, out int num))
{
    Console.WriteLine($"{str} не является числом");
    return;
};

if ((num < 1)||(num > 7))
{
    Console.WriteLine($"Номер дня недели должен быть в диапазоне 1..7");
    return;
}

switch (num)
{
    case 6:
        Console.WriteLine("Суббота, выходной");
        break;
    case 7:
        Console.WriteLine("Воскресенье, выходной");
        break;
    default:
        Console.WriteLine("Будний день");
        break;
}