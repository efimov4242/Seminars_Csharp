// Дополнительно. Дан массив чисел. Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем. При отсутствии числа возвращать -1

int[] arr = { 1, 5, 3, 4, 6 };

int GetNumbIndex(int[] array, int number)
{
	for (int i = 0; i < array.Length; i++)
	{
		if(array[i] == number)
			return i;
	}
	return -1;
}

System.Console.WriteLine(GetNumbIndex(arr, 5));
