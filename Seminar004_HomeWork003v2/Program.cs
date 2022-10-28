int[] array = new int[8];
Random random = new Random();
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
	array[i] = random.Next(100);
	Console.Write("{0} ", array[i]);
}
Console.WriteLine();