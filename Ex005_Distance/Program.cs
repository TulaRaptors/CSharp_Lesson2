// Найти расстояние между точками в пространстве 2D/3D

using System;

Console.Clear();

void FillArray(double[] point)
{
    Console.Write("Введите х: ");
    point[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите y: ");
    point[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите z: ");
    point[2] = Convert.ToDouble(Console.ReadLine());
}

double[] point1 = new double[3];
double[] point2 = new double[3];

Console.WriteLine("Введите координаты первой точки: ");
FillArray(point1);
Console.WriteLine("Введите координаты второй точки: ");
FillArray(point2);

double distance = Math.Sqrt(
    Math.Pow(point2[0]-point1[0], 2) + 
    Math.Pow(point2[1]-point1[1], 2) + 
    Math.Pow(point2[2]-point1[2], 2));

Console. WriteLine();
Console.Write("Расстояние между точками равно: " + Math.Round(distance, 2));