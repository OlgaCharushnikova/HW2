﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозночающую день недели: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 6 || x == 7 )
{
    Console.WriteLine($"{x} -> да");
}
else
{
     Console.WriteLine($"{x} -> нет"); 
}