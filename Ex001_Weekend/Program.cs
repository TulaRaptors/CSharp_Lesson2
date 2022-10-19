// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

using System;

Console.Clear();
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt16(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("ВЫХОДНОЙ ДЕНЬ!");
    }
    else
    {
        Console.WriteLine("Будний день =(");
    }
}
else
{
    Console.WriteLine("Такого дня недели не существует!");
}