﻿double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{

    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+  Math.Pow(z2 - z1, 2)), 2);
}


Console.WriteLine("Введите x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z1");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z2");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{FindDistance(x1, y1, z1, x2, y2, z2)}"); 