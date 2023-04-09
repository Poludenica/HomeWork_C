// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] RandomArray(int lenghtArray)
{
    int[] newArray = new int[lenghtArray];
	for (int i = 0; i < newArray.Length; i++)
	{
		newArray[i] = new Random().Next(100, 1000);
	}
	return newArray;
}

int QuantityEvenNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("Your array: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
        
    }
    Console.WriteLine();
}

Console.Write("Input the length of the array: ");
int lenghtArray = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(lenghtArray);

PrintArray(array);
Console.WriteLine($"The quantity even numbers in array: {QuantityEvenNum(array)}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] RandomArray(int lenghtArray)
{
    int[] newArray = new int[lenghtArray];
	for (int i = 0; i < newArray.Length; i++)
	{
		newArray[i] = new Random().Next(1, 1000);
	}
	return newArray;
}

void PrintArray(int[] array)
{
    Console.Write("Your array: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
        
    }
    Console.WriteLine();
}

 int EvenPosInArray(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2) sum += array[i];
    return sum;
}

Console.Write("Input the length of the array: ");
int lenghtArray = Convert.ToInt32(Console.ReadLine());

int [] array = RandomArray(lenghtArray);

PrintArray(array);
System.Console.WriteLine($"The sum of the numbers on odd positions {EvenPosInArray(array)}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

/*
double[] RandomArray(int lenghtArray)
{
    double[] newArray = new double[lenghtArray];
	for (int i = 0; i < newArray.Length; i++)
	{
		newArray[i] = Math.Round(new Random().NextDouble() + new Random().Next(1, 10), 2);
	}
	return newArray;
}

void PrintArray(double[] array)
{
    Console.Write("Your array: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
        
    }
    Console.WriteLine();
}
double DiffMinMax(double[] array)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        max = Math.Max(max, array[i]);
        min = Math.Min(min, array[i]);
    }
    double diff = max - min;
    return diff;
}
Console.Write("Input the length of the array: ");
int lenghtArray = Convert.ToInt32(Console.ReadLine());

double [] array = RandomArray(lenghtArray);

PrintArray(array);
System.Console.WriteLine($"The diff of min and max number is {Math.Round(DiffMinMax(array), 2)}");
*/