// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int IsNumberInArray(int[,] array, int number)
{

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if(array[i, j] == number)
			return number;
		}
	}
	return "Такого элемента нет";
}

int[,] RandomArray(int y, int x, int minValue = 0, int maxValue = 10)
{
	int[,] newArray = new int[y, x];
	var rnd = new Random();

	for (int i = 0; i < newArray.GetLength(0); i++)
	{
		for (int j = 0; j < newArray.GetLength(1); j++)
		{
			newArray[i, j] = rnd.Next(minValue, maxValue + 1);
		}
	}
	return newArray;
}

