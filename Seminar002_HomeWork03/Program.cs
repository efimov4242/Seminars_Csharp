// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру дня недели");
int dayNumber = int.Parse(Console.ReadLine());

if(dayNumber >= 1 & dayNumber <= 5)
	System.Console.WriteLine("Нет");
if(dayNumber >= 6 & dayNumber <= 7)
	System.Console.WriteLine("Да");
else
	System.Console.WriteLine("Введите число от 1 до 7");