// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumDigits(int number)
{
	int i = 0;
	int sum = 0;
	while (i < number)
	{
		sum += number % 10;
		number /= 10;
	}
	return sum;
}

Console.WriteLine(GetSumDigits(452)); // -> 11