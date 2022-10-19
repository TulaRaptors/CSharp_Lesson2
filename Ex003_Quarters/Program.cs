// Задать номер четверти, показать диапазоны для возможных координат

using System;

Console.Clear();
Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Координаты для I четверти х>0 и у>0");
}
else if (number == 2)
{
    Console.WriteLine("Координаты для II четверти х<0 и у>0");
}
else if (number == 3)
{
    Console.WriteLine("Координаты для III четверти х<0 и у<0");
}
else if (number == 4)
{
    Console.WriteLine("Координаты для IV четверти х>0 и у<0");
}
else 
{
    Console.WriteLine("Такой четверти не существует!");
}
