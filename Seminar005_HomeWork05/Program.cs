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


int[] GetMultiplyFirstAndLastNumbers(int[] array)
{
	for (int i = 0, j = array.Length-1; i < array.Length/2; i++, j--)
	{
		array[i] = array[i] * array[j];
	}
	return array;
}




int[] newArray = GetRandomArray(6, 1, 10);
PrintRandomArray(newArray);
Console.WriteLine();
int[] myArray = GetMultiplyFirstAndLastNumbers(newArray);
Console.WriteLine(String.Join(" ", myArray));