﻿//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int PositiveNumberCounter(int M)
// {
//     int count = 0;
//     for (int i = 0; i < M; i++)
//     {
//         Console.Write("Введите число: ");
//         int k = Convert.ToInt32(Console.ReadLine());
//         if (k > 0)
//             count++;
//     }
//     return count;
// }
// Console.Write("Введите количество чисел: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PositiveNumberCounter(M));

//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double IntersectionPoint(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     return Math.Round(x, 2);
// }
// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2 && b1 == b2)
//     Console.WriteLine("Точки пересечения нет. Прямые совпадают.");
// else
// {
//     if (k1 == k2)
//         Console.WriteLine("Точки пересечения нет. Прямые параллельны.");
//     else
//     {
//         double x = IntersectionPoint(b1, k1, b2, k2);
//         Console.WriteLine($"Точка пересечения заданных прямых найдена: х = {x}, y = {(k1 * x + b1)} ");
//     }
// }




