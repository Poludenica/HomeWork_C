//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
//вариант 1. Где пользователю предлагается ввести мин отрицательное число.

// int[,] CreateRandomArray2D()
// {
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of colums: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min negative value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);

//         }
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] myArray = CreateRandomArray2D();
// Show2DArray(myArray);

// вариант 2. Где при рандоме искусственно ограничиваем область.

// int[,] CreateRandomArray2D()
// {
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of colums: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(-100, 100);

//         }
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] myArray = CreateRandomArray2D();
// Show2DArray(myArray);

//Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

// вариант 1 через if И else, без метода void

// int[,] CreateRandomArray2D(int rows, int colums, int minValue, int maxValue)
// {

//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);

//         }
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandomArray2D(rows, colums, minValue, maxValue);
// Show2DArray(myArray);
// Console.WriteLine("Input the coordinates: ");
// int rowEl = Convert.ToInt32(Console.ReadLine());
// int colEl = Convert.ToInt32(Console.ReadLine());

//     if (rowEl > rows && colEl > colums)
//         Console.WriteLine("That number does not exist.");
//     else
//     {
//         int c = myArray[rowEl, colEl];
//         Console.WriteLine("array element value is " + c);
//     }

// вариант 2. ЧЕрез void

// int[,] CreateRandomArray2D(int rows, int colums, int minValue, int maxValue)
// {

//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);

//         }
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandomArray2D(rows, colums, minValue, maxValue);
// Show2DArray(myArray);
// Console.WriteLine("Input the coordinates: ");
// int rowEl = Convert.ToInt32(Console.ReadLine());
// int colEl = Convert.ToInt32(Console.ReadLine());

// void Element(int[,] array, int rowEl, int colEl)
//   {

//     if (rowEl < 0 || colEl <0 || rowEl > array.GetLength(0) || colEl > array.GetLength(1))
//         Console.WriteLine("That number does not exist.");
//     else
//     {
//         int c = myArray[rowEl, colEl];
//         Console.WriteLine("array element value is " + c);
//     }
//   }
// Element(myArray, rowEl, colEl);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] CreateRandomArray2D()
// {
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of colums: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] myArray = CreateRandomArray2D();
// Show2DArray(myArray);

// Console.Write("The arithmetic mean of each column is equal: ");
// for (int j = 0; j < myArray.GetLength(1); j++)
// {
//     int sum = 0;
//     for(int i = 0; i < myArray.GetLength(0); i++)
//     {
//         sum = sum + myArray[i,j];
//     }
// double average = Math.Round(Convert.ToDouble(sum) / myArray.GetLength(1), 2);
// Console.Write($"{average}; ");
// }
