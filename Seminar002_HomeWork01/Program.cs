﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetSecondDigit(int number)
{
    return number / 10 % 10;
}

System.Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine(GetSecondDigit(number));

