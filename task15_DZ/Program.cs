﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.6 -> да; 7 -> да; 1 -> нет
Console.WriteLine("Введите цифру, соответствующую дню недели: ");
int dweek = Convert.ToInt32(Console.ReadLine());
if (dweek < 1 || dweek > 7)
{
    Console.WriteLine("Число не соответствует дню недели!");
}
else
{
    if (dweek == 6 || dweek == 7)
    {
        Console.WriteLine("Да, это выходной день! Ура!!!");
    }
    else
    {
        Console.WriteLine("Нет, это не выходной день, попробуйте еще!");
    }
}