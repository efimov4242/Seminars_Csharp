// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


void PrintSumEvenNumber(int arrayLength, int minValue = 100, int maxValue = 1000)
{
	int[] array = new int[arrayLength];
	var rnd = new Random();
	int result = 0;
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(minValue, maxValue);
		if (array[i] % 2 == 0)
			result++;
	}
	Console.WriteLine(result);
}


PrintSumEvenNumber(4);
