﻿// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

int numberB = 1;
while (numberB <= numberA)
{
    if (numberB % 2 == 0)
    Console.Write($"{numberB} ");
    numberB++;
}