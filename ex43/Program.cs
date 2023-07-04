/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


Console.Clear();

Console.WriteLine("Введите b1, k1, b2, k2 через пробел:");
string [] array = Console.ReadLine().Split(); 
int b1 = int.Parse(array[0]);
int k1 = int.Parse(array[1]);
int b2 = int.Parse(array[2]);
int k2 = int.Parse(array[3]);

