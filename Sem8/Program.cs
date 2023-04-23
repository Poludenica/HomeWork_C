// задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строки массива
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

// void ChengeRows(int[,] array, int row1, int row2)
// {
//     if(row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     else Console.WriteLine("Wrong row numbers");
// }
// int[,] myArray = CreateRandomArray2D();
// Show2DArray(myArray);

// Console.Write("Input number of the first row for change ");
// int r1 = Convert.ToInt32(Console.ReadLine()) -1;
// Console.Write("Input number of the second row for change ");
// int r2 = Convert.ToInt32(Console.ReadLine()) -1 ;

// ChengeRows(myArray, r1, r2);


// задайте двумерный массив и напишите программу, которая заменяет строки на столбцы/
int[,] CreateRandomArray2D()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);

        }
    }
    return array;
}
void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] myArray = CreateRandomArray2D();
Show2DArray(myArray);

void TurnArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < i; j++)
    {
        
        {
            int temp = array[i,j];
            array[i, j] = array [j,i];
            array[j,i] = temp;
            
        } 
    }  

    }
}
// задача 58. Произведение матриц. 
// Задача  60. как сформулировать массив из неповторяющихся двузначных чисел.
// на логику.


// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент