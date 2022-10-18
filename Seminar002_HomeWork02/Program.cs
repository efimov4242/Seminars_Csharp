// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int LastDigit(int number)
{
    {
	if(number > 99 & number < 999)
	return number % 10;
    }
    {
	if(number > 999 & number < 9999)
	return number / 10 % 10;
    }
    {
    if(number > 9999 & number < 99999)
	return number / 100 % 10;
    }
    {
    return -1;
    }
}

System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(LastDigit(number));
