// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] RandomArray(int m = 3, int n = 4, int minValue = -10, int maxValue = 10)
{
	double[,] newArray = new double[m, n];
	var rnd = new Random();
	for (int i = 0; i < newArray.GetLength(0); i++)
	{
		for (int j = 0; j < newArray.GetLength(1); j++)
		{
			newArray[i, j] = Math.Round(rnd.NextDouble() * (maxValue - minValue) + minValue, 1);
		}
	}
	return newArray;
}


void PrintArray(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

double[,] randomArray = RandomArray();

PrintArray(randomArray);