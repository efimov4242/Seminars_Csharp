// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void IsPalindrome(int number)
{
	string numberStr = number.ToString();
	int numberLenght = numberStr.Length;

	if (numberLenght == 5)
	{
		int oldNumber = number;
		int newNumber = 0;
		while (number > 0)
		{
			int a = number % 10;
			newNumber = newNumber * 10 + a;
			number = number / 10;
		}
         if (newNumber == oldNumber)
				Console.WriteLine("Число является палиндромом");
         else
				Console.WriteLine("Число не является палиндромом");
	}
	else
	{
		Console.WriteLine("Введите пятизначное число палиндром");
		return;
	}
}

IsPalindrome(12821);