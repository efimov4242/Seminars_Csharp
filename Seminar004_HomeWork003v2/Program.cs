// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArrayRandom8()
{
int[] array = new int[8];
Random random = new Random();
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
	array[i] = random.Next(100);
	Console.Write("{0} ", array[i]);
}
Console.WriteLine();
}

PrintArrayRandom8();