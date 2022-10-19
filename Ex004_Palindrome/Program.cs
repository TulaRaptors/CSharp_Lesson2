// Программа проверяет пятизначное число на палиндромом.

using System;

Console.Clear();
Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();
if (number.Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Число является палиндромом!");
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом");
    }
}
else 
{
    Console.WriteLine("Вы ввели не пятизначное число!");
}