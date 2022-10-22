// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 ->

// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());

// if (number < 100)
// {
// Console.WriteLine("Третьей цифры нет");
// }
// else
// {
// while (number >= 1000)
// {
// number /= 10;
// }
// Console.WriteLine(number % 10);
// }

// Второй вариант решения через массивы

Console.WriteLine("Введите число");
string stringNumber = Console.ReadLine();

if (stringNumber.Length < 3) // или stringNumber.Length < 3;
{
Console.WriteLine("Третьей цифры нет");
}
else
{
Console.WriteLine(stringNumber[2]);
}


