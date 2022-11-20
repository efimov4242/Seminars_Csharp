// Дополнительно.
// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11

// void PrintPrimeNumber(int number)
// {
// 	int i = 2;
// 	int k = 0;
// 	while (i <= number)
// 	{
// 		if(i % 2 != 0)
// 		k = i+1;
// 		if(i % 3 !=0)
// 		Console.WriteLine(i);
// 		i++;

// 	}
// }

// PrintPrimeNumber(97);
void Metodee(string str, int ch = 3)
{
	System.Console.WriteLine($"{str.Substring(0, ch)}...");
}

Metodee("Ghnncnc");

void IsInternationalMumber(string number)
    {
        System.Console.WriteLine(number[0] == '+');
    }
    // END

