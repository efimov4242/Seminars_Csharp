// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] PrintArray()
{
	int n = 8; // колличество элементов в массиве
	int[] array = new int[n];
	for (int i = 0; i < n; i++)
	{
		array[i] = new Random().Next(0, 100);
		Console.Write($"{array[i]}");
	}
	return array;
}
