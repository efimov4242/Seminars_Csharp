// Задача 1
// Напишите программу, котора принимает число и выдает количество цифр в числе
int PrintCountDigits(int number)
{
	return number.ToString().Length;
}

int PrintCountDigitsFor(int number)
{
	int count = 0;
	for (int i = 1; i <= number; i++)
	{
		number = number / 10;
		count = count + 1;
	}
	return count;
}

// Console.WriteLine(PrintCountDigits(12));
// Console.WriteLine(PrintCountDigitsFor(12));

// Задача 2
// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int FactorialNumber(int number)
{
	int count = 1;
	for (int i = 1; i <= number; i++)
	{
		count = count * i;
	}
	return count;
}

// Console.WriteLine(FactorialNumber(5));

// Задача 3
// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

int GetSumOneToRoundA(int number)
{
	int sum = 0;
	for (int i = 0; i <= number; i++)
	{
		sum = i + sum;
	}
	return sum;
}

System.Console.WriteLine(GetSumOneToRoundA(7));
