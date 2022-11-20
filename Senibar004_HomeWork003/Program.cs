// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


/*void PrintArray(int indexCount, int maxValue)
{

int[] array = new int[indexCount];
Random rand = new Random();
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
	array[i] = rand.Next(maxValue);
	Console.Write(array[i]);
	if(i < array.Length -1)
		{
		Console.Write(", ");
		}
}
Console.Write("]");
Console.WriteLine();
}

PrintArray(50, 10);
*/
/*
int[] array = {2, 1, 3, 5, 7, 8};
	for (int j = 0; j < array.Length; j++)
	{
		for (int i = 0; i < array.Length-1; i++)
		{
			if (array[i] > array[i + 1])
			{
			int temp = array[i];
			array[i] = array[i + 1];
			array[i + 1] = temp;
			}

		}
		Console.Write("{0} ", array[j]);
	}
*/

int PrintFactorial(int number)
{
	int result = 1;
	for (int i = 1; i <= number; i++)
	{
		result = result * i;

	}
	return result;
}

System.Console.WriteLine(PrintFactorial(4));





