// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void PrintDistance2D(int ax, int bx,
		     int ay, int by,
		     int az, int bz)
{
	int aCatet = bx - ax;
	int bCatet = ay - by;
	int cCatet = az - bz;
	int hypotenuse = (aCatet*aCatet) + (bCatet*bCatet) + (cCatet*cCatet);
	Console.WriteLine(Math.Round(Math.Sqrt(hypotenuse), 2));
}

int ax = 3;
int bx = 6;
int ay = 8;
int by = 2;
int az = 1;
int bz = -7;
PrintDistance2D(ax, bx, ay, by, az, bz);
