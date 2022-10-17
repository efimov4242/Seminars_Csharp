// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int index = 2;
while(index <= number)
{
    System.Console.WriteLine(index);
    index = index + 2;
}

// Второй вариант решения
// while(index <= number)
// {
//     if(index % 2 == 0)
//     System.Console.WriteLine(index);
//     index++;
// }

