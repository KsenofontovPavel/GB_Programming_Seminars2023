// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое 
// число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int numberset = numberA * numberA;
if(numberset == numberB)
{
    Console.Write("Квадрат первого числа равен второму числу: ");
}
else
{
    Console.Write("Квадрат первого числа не равен второму числу: ");
}



