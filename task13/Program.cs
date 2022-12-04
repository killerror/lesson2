/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
var str = Console.ReadLine();

if (!int.TryParse(str, out int num))
{
    Console.WriteLine($"{str} не является числом");
    return;
};

num = Math.Abs(num);
if (num < 100)
{
    Console.WriteLine($"В числе {str} нет третьей цифры");
    return;
}

Console.WriteLine($"Третья цифра числа {str}: {num.ToString()[2]}");