// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNaturalDegreeNumber(int number, int pow)
{
	int count = 0;
	for (int i = 0; i <= pow; i++)
	{
		count = number * i;
	}
	return count;
}

System.Console.WriteLine(GetNaturalDegreeNumber(3, 5));
