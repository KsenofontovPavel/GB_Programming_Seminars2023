/*Задача 13: Напишите программу, которая выводит третью
цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int Length = number.ToString().Length;
if (Length >= 3) 
{
	while  (number > 1000)
	{
		number = number / 10;
	}
	int result = number % 10;
	Console.WriteLine("Третья цифра заданного числа: " + result);
} 
else 
{
	Console.WriteLine("Третья цифра отсутствует!!!");
}
