// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void GetAverageColumn(int[,] array)
{
	Console.Write("Среднее арифметическое каждого столбца: ");
	for (int i = 0; i < array.GetLength(1); i++)
	{
		double colSum = 0;
		double average = 0;
		for (int j = 0; j < array.GetLength(0); j++)
		{
			colSum += array[j, i];
		}
		average = colSum / array.GetLength(0);
		Console.Write(Math.Round(average, 1) + " ");
	}

}


int[,] someArray = new int[,] {{1, 4, 7, 2},
				{5, 9, 2, 3},
				{8, 4, 2, 4}};

GetAverageColumn(someArray);
