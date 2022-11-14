// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GetRandomNumbArray(int arrayLength)
{
	int[] array = new int[arrayLength];
	var rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(100);
	}
	return array;
}

void GetIndexUnevenPosition(int[] myArray)
{
	int sum = 0;
	for (int i = 0; i < myArray.Length; i = i + 2)
	{
		sum += myArray[i];
	}
	System.Console.WriteLine(sum);
}

int[] randomArray = GetRandomNumbArray(7);
System.Console.WriteLine(String.Join(", ", randomArray));
GetIndexUnevenPosition(randomArray);