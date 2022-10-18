// Дополнительная Задача 9
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

<<<<<<< HEAD
=======

// void GetCheckNumber(int number)
// {
// 	{
// 	if(number % 7 == 0 & number % 23 == 0)
// 	System.Console.WriteLine("Да");
// 	}
// 	System.Console.WriteLine("Нет");
// }

>>>>>>> 0d5b6d2ab89ae5df8c61a5ca7245a9699421da37
Console.WriteLine("Введите число кратное одновременно 7 и 23");
int number = int.Parse(Console.ReadLine());

if(number % 7 == 0 & number % 23 == 0)
	System.Console.WriteLine("Да");
else
	System.Console.WriteLine("Нет");

