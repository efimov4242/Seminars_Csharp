// Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.

int[] array = {1, 3, 5, 10, 9, 22, 4};

int temp;
for (int j = 0; j < array.Length; j++)
{

	for (int i = j+1; i < array.Length; i++)
	{
		if(array[j] > array[i])
		{
			temp = array[i];
			array[i] = array[j];
			array[j] = temp;
		}
	}

	System.Console.WriteLine(array[j]);
}