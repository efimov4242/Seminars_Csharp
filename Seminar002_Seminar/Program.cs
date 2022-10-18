//  Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру.

 int MaxDigit(int number)
 {
 	{
 	if(number % 10 > number / 10)
 	return number % 10; // Остаток от деления на 10
 	}
 	return number / 10; // Число без остатка
 }
 int number = new Random().Next(10, 100);
 System.Console.WriteLine(MaxDigit(number));
