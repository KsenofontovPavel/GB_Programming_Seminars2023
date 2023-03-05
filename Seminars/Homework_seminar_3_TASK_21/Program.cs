/*Задача 21: Напишите программу, которая принимает
на вход координаты двух точек и находит расстояние
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int X1 = ReadInt("Введите координату X первой точки: ");
int Y1 = ReadInt("Введите координату Y первой точки: ");
int Z1 = ReadInt("Введите координату Z первой точки: ");
int X2 = ReadInt("Введите координату X второй точки: ");
int Y2 = ReadInt("Введите координату Y второй точки: ");
int Z2 = ReadInt("Введите координату Z второй точки: ");

int A = X2 - X1;
int B = Y2 - Y1;
int C = Z1 - Z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длина отрезка {length}");


int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
