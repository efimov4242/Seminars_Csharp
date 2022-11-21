// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void IsNumberInArray(int[,] array, int m, int n)
{
	int number = 0;

	if (n > array.GetLength(0) || m > array.GetLength(1))
	    Console.WriteLine("Такого числа в массиве нет");
	else
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
		for (int j = 0; j < array.GetLength(1); j++)
		{
		    if (array[i, j] == array[m, n])
			number = array[m, n];
		}
	    }
	    Console.WriteLine(number);
	}
	Console.WriteLine(array.GetLength(1));
}



int[,] RandomArray(int y, int x, int minValue = 0, int maxValue = 10)
{
	int[,] newArray = new int[y, x];
	var rnd = new Random();

	for (int i = 0; i < newArray.GetLength(0); i++)
	{
	    for (int j = 0; j < newArray.GetLength(1); j++)
	    {
		newArray[i, j] = rnd.Next(minValue, maxValue);
	    }
	}
	return newArray;
}

int[,] randomArray = RandomArray(3, 4);
IsNumberInArray(randomArray, 2, 3);
