// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = { 3, 7, 22, 2, 78 };

void GetFindDiffMaxMinElements(int[] arr)
{
	int min = arr[0];
	int max = arr[0];
	for (int i = 0; i < arr.Length; i++)
	{
		if(arr[i] < min)
			min = arr[i];
		if(arr[i] > max)
			max = arr[i];
	}
	int diff = max - min;
	System.Console.WriteLine("Минимальный элемент массива: " + min);
	System.Console.WriteLine("Максимальный элемент массива: " + max);
	System.Console.WriteLine("Разница: " + diff);

}

System.Console.WriteLine("[" + String.Join(" ", array) + "]");
GetFindDiffMaxMinElements(array);