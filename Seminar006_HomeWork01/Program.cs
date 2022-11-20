// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int GetCountPositiveNumber(int countInput)
{
	int[] array = new int[countInput];
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		System.Console.WriteLine("Введите число: ");
		array[i] = int.Parse(Console.ReadLine());
		if(array[i] > 0)
			sum++;
	}
	return sum;
}

System.Console.WriteLine("Чисел больше 0 : " + GetCountPositiveNumber(5));