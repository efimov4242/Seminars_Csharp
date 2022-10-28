// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите 8 чисел");

int a = int.Parse(Console.ReadLine());

int b = int.Parse(Console.ReadLine());

int c = int.Parse(Console.ReadLine());

int d = int.Parse(Console.ReadLine());

int e = int.Parse(Console.ReadLine());

int f = int.Parse(Console.ReadLine());

int g = int.Parse(Console.ReadLine());

int h = int.Parse(Console.ReadLine());

int[] myArray = {a, b, c, d, e, f, g, h};

for (int i = 0; i < myArray.Length; i++)
{
	Console.Write(myArray[i]);
	if(i < myArray.Length -1)
		for (int j = 0; j < 1; j++)
		{
		Console.Write(", ");
		}
}

Console.WriteLine();
