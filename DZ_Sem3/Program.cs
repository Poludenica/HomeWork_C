//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool Palindrom(int n)
// {
//     int nConst = n;
//     int nNew = 0;
//     while (n > 0)
//     {
//         int lastDigit = n % 10;
//         nNew = nNew * 10 + lastDigit;
//         n = n / 10;
//     }
//     if (nNew == nConst)
//         return true;
//     else return false;
// }

// Console.WriteLine("Введите любое целое число: ");
// int p = Convert.ToInt32(Console.ReadLine());

// if (Palindrom(p) == true)
//     Console.WriteLine("Это число является палиндромом.");
// else Console.WriteLine("Это число не является палиндромом.");



//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Length(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// }

// Console.Write("Введите x точки А: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите у точки А: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z точки А: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите x точки B: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите у точки B: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z точки B: ");
// int z2 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine($"Расстояние между точками А и В равно {Math.Round(Length(x1, y1, z1, x2, y2, z2), 2)}");


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Cub(int n)
// {
//     int i = 1;
//     while (i <= n)
//     {
//         Console.WriteLine($"{i} - {Math.Pow(i, 3)}");
//         i++;
//     }
// }
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Cub(N);
