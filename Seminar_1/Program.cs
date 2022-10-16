//Напишите программу, которая на вход принимает число и выдает его квадрат

// System.Console.WriteLine("Введите число ");
// int number = int.Parse(Console.ReadLine()); //int.Parse - преобразует строку в число

// System.Console.WriteLine($"Квадрат числа = {number * number}");



// Задача 1. 
// Напишите программу, которая принимает на вход два числа и проверяет, является ли второе число квадратом первого.

// System.Console.WriteLine("Введите первое число ");
// int number = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Введите квадрат первого числа ");
// int square = int.Parse(Console.ReadLine());

// if(square == number * number)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
// System.Console.WriteLine("Нет");
// }


// Задача 2.
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

System.Console.WriteLine("Введите номер дня недели ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("Понедельник");
}
if (number == 2)
{
    System.Console.WriteLine("Вторник");
}
if (number == 3)
{
    System.Console.WriteLine("Среда");
}
if (number == 4)
{
    System.Console.WriteLine("Четверг");
}
if (number == 5)
{
    System.Console.WriteLine("Пятница");
}
if (number == 6)
{
    System.Console.WriteLine("Суббота");
}
if (number == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else
{
System.Console.WriteLine("Введите число от 1 до 7");
}