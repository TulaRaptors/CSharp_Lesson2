// По двум заданным числам проверять является ли одно квадратом другого

using System;

Console.Clear();

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == Math.Pow(numberB, 2))
{
    Console.WriteLine("Первое число является квадратом второго");
}
else if (numberB == Math.Pow(numberA, 2))
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Числа не связаны друг с другом квадратной степенью");
}