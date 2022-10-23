//Напишите программу, которая принимает на вход координаты точки (x и y),
//причем X!=0 и Y!=0 и выдает число номер четверти, в которой находится эта точка.

int GetNumberOfPlane(int x, int y)
{
	if (x > 0 && y > 0) return 1;
	if (x == 0 || y == 0) return -1;

	if (x < 0 && y > 0) return 2;
	if (x < 0 && y < 0) return 3;
	if (x > 0 && y < 0) return 4;
	else return -1;
}

void PrinterNumberOfPlane(int x, int y)
{
	if (x == 0 || y == 0)
	{
		System.Console.WriteLine("Неверные координаты");
		return;
	}

	int numberOfPlane;
	if (x > 0 && y > 0) numberOfPlane = 1;
	else if (x < 0 && y > 0) numberOfPlane = 2;
	else if (x < 0 && y < 0) numberOfPlane = 3;
	else if (x > 0 && y < 0) numberOfPlane = 4;
	else numberOfPlane = -1;

	System.Console.WriteLine($"Номер плоскости: {numberOfPlane}");
}

int x = -19, y = 20;
PrinterNumberOfPlane(x, y);

 //Console.WriteLine($"Номер плоскости: {GetNumberOfPlane(-19, 20)}");

 //Задача №2.
 //Напишите программу, которая по заданному номеру четверти, роказывает дипазон возможных
 //координат точек в этой четверти (X и y).

 void PrintCoordinatName(int number)
 {
	if (number == 1)
	System.Console.WriteLine("x = + n, y = + n");
	else if (number == 2)
	System.Console.WriteLine("x = - n, y = + n");
	else if (number == 3)
	System.Console.WriteLine("x = - n, y = - n");
	else if (number == 4)
	System.Console.WriteLine("x = + n, y = - n");
	else
	{
		System.Console.WriteLine("Неверное число");
			return;
	}
}

int number = 3;
PrintCoordinatName(number);


