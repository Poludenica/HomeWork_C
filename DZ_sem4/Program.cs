// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
void Quad(int a, int b)
{
    int result = a;
    for(int i = 1;i < b; i++)
    {
        result = result * a;

    }
    Console.WriteLine($"The number {a} in power of {b} is equal to {result} ");
}

Console.WriteLine("Input number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b: ");
int b = Convert.ToInt32(Console.ReadLine());

Quad(a,b);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SumNum(int num)
{
    int result = 0;
    for(int i = 0; num > 0; i++)
    {
        result += num % 10;
        num /= 10;
        
    }    
    return result;
}

Console.WriteLine("Input number : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum is " + SumNum(num));
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//  int[] GetRandomArray(int lenArray)
// {
//     int[] array = new int[lenArray];
//     for (int i = 0; i < lenArray; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// PrintArray(GetRandomArray(8));
