// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
    // [1 2 3 4 5] -> 5 8 3
    // [6 7 3 6] -> 12 10


int[] GetRandomArray(int arrayLenght, int minValue, int maxValue)
{
	int[] array = new int[arrayLenght];
	var rnd = new Random();
	for (int i = 0; i < arrayLenght; i++)
	{
		array[i] = rnd.Next(minValue, maxValue + 1);
	}
	return array;
}


void PrintRandomArray(int[] array)
{
	foreach (var item in array)
	{
		Console.Write(item + " ");
	}
}


void PrintSumFirstAndLastNumbers(int[] array)
{
	int sum = 0;
	for (int i = 0, j = array.Length - 1; i < array.Length/2; i++, j--)
	{
		sum = array[i] + array[j];
		Console.Write(sum + " ");
	}
}


int[] newArray = GetRandomArray(5, 1, 10);
PrintRandomArray(newArray);
Console.WriteLine();
PrintSumFirstAndLastNumbers(newArray);
Console.WriteLine();