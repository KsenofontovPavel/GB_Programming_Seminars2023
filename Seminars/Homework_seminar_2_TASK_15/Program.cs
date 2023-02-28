/*Задача 15: Напишите программу, которая принимает на вход
цифру, обозначающую день недели, и проверяет, является ли
этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = int.Parse(Console.ReadLine());

if (dayNumber>= 1 && dayNumber <=7) 
{
	if (dayNumber >= 6) 
    {
		Console.Write("Ура, это ВЫХОДНОЙ");
	} 
    else 
    {
		Console.Write("Рабочий день");
	}
} 
else 
{
	Console.Write("Эта цифра не является днём недели");
}

