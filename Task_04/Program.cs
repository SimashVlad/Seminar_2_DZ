﻿// Напишите программу, которая на вход 
// принимает число(N), а на выходе 
// показывает все чётные числа от  1 до N.

Console.WriteLine("Введите целое число");
int N = int.Parse(Console.ReadLine());
int Y = 1;
while (Y <=N)
{
    if (Y % 2 == 0)
    Console.Write(Y +" ");
    Y++;
}