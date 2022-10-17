// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetLastDigit(int number)
{
    int lastDigit = number / 10 % 10;
    return lastDigit;
}

System.Console.WriteLine(GetLastDigit(783));
