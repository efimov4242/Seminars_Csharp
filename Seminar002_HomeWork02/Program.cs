// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 ->

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number < 100)
	Console.WriteLine("Третьей цифры нет");
if (number >= 100 & number <= 1000)
	Console.WriteLine(number % 10);
else
{
	int index = 100;
	while (index < number)
    {
        number = number / 10;
        if(number > 100 & number < 1000)
            Console.WriteLine(number % 10);
        index++;
    }
}


