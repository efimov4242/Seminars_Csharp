// Дополнительно.
// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11

void PrintPrimeNumber(int number)
{
	int i = 2;
	while (i <= number)
	{
		if(i % 2 != 0)
		Console.WriteLine(i);
		i++;
	}
}

PrintPrimeNumber(97);
