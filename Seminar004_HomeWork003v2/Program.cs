void Array()
{

int a = new Random().Next(0, 100);

int b = new Random().Next(0, 100);

int c = new Random().Next(0, 100);

int d = new Random().Next(0, 100);

int e = new Random().Next(0, 100);

int f = new Random().Next(0, 100);

int g = new Random().Next(0, 100);

int h = new Random().Next(0, 100);

int[] myArray = {a, b, c, d, e, f, g, h};

for (int i = 0; i < myArray.Length; i++)
{
	Console.Write(myArray[i]);
	if(i < myArray.Length -1)
		for (int j = 0; j < 1; j++)
		{
		Console.Write(", ");
		}
}
}
Console.WriteLine();

Array();
