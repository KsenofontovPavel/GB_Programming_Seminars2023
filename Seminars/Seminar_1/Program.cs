// Команда, которая выводит что-то в консоль
// Console.WriteLine("Hello, World 123!");
// Получение входного числа от пользователя
// Console.Write("Введи целое число: ");
// int number = int.Parse(Console.ReadLine());
// Квадрат входного числа
//int result = number * number;
// Console.WriteLine($"Квадрат входного числа = {result}");

Console.WriteLine("Введите трехзначное число: ");

int number = int.Parse(Console.ReadLine());

int result = number % 10;

Console.WriteLine($"Последняя цифра = {result}");
