// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void PrintArray(int indexCount, int maxValue)
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

