// Задача 19
// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Задача 21
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату по оси OX для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси OY для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси OZ для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси OX для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси OY для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси OZ для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
double  d = (Math.Round(Math.Pow(x2-x1, 2) + Math.Pow(y2-((byte)y1), 2)+ Math.Pow(z2-z1, 2), 2));
Console.WriteLine("расстояние: {d}");
