/*Задача 10: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую цифру этого
числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int Length = number.ToString().Length;
if (Length == 3) 
{
	int result = ( number/10 ) % 10;
	Console.WriteLine("Вторая цифра этого числа " + result);
} 
else 
{
	Console.WriteLine("Число не является трёхзначным");
}
