// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("введите x1: ");
int x1=int.Parse(Console.ReadLine());
Console.Write("введите y1: ");
int y1=int.Parse(Console.ReadLine());
Console.Write("введите z1: ");
int z1=int.Parse(Console.ReadLine());
Console.Write("введите x2: ");
int x2=int.Parse(Console.ReadLine());
Console.Write("введите y2: ");
int y2=int.Parse(Console.ReadLine());
Console.Write("введите z2: ");
int z2=int.Parse(Console.ReadLine());

Console.WriteLine("точка А с координатами"+"("+x1+";"+y1+";"+z1+")"+"точка В с координатами"+"("+x2+";"+y2+";"+z2+")");

double distance=Math.Sqrt((Math.Pow(x2-x1,2))+(Math.Pow(y2-y1,2))+(Math.Pow(z2-z1,2)));

Console.WriteLine("Расстояние между точками А и В: "+distance);
