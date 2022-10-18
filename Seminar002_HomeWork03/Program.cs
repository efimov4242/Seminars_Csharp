// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void GetWeekend(int dayNumber)
{
	{
	if(dayNumber >= 1 & dayNumber <= 5)
	System.Console.WriteLine("Нет");;
	}
	if(dayNumber >= 6 & dayNumber <= 7)
	System.Console.WriteLine("Да");;
	{
	System.Console.WriteLine("Введите число от 1 до 7");;
	}
}

System.Console.WriteLine("Введите цифру дня недели");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine(GetWeekend(number));