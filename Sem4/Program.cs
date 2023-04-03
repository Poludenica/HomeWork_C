//Task 1.Напишите программу, которая принимает на вход 
//число (А) и выдаёт сумму чисел от 1 до А. 

// тип метода int


//int GetSum(int num)
//{
  //  int sum = 0;
// цикл фор при организации цикла, вместо одного блока 
// будет три. каждый отвечает за ссвою часть. Целесообразнее использовать при массивах.
    // for(int current = 1 /*рабочая переменная. только в цикле работает*/; current <= num /*логическое условие*/; current++ /*что будет меняться с переменной*/)
   // {
    //    sum = sum + current; //смысловое назначение цикла
    // }
    // если осуществлять через while. Больше используется,когда не нужна отдельная рабочая переменная. только одна переменная
    // int current = 1; переменная объявляется до цикла
    // while (current <= num)
    // {
     //   sum = sum + current;
     //   current++;
     //    }
 //    return sum;
// }

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());

//int res = GetSum(a);
//Console.WriteLine($"Sum of numbers from 1 to {a} is {res}"); 


// Task 2. Напишите программу,
// которая принимает на вход число и выдаёт количество цифр в числе.

// int CountNum(int num)
// {
//     int total = 0;
    

//     while(num > 0)
//     {
//       num = num / 10;
//       total++;
//     }
//     return total;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Цифр в числе {num} : {CountNum(num)}");

// Task 3. Напишите программу,
// которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


int multiplyNum(int num)
{
    int total = 1;
    for(int i = 1; i <= num; i++)
    {
      total = total * i;   
    }
    return total;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Факториал числа {num} : {multiplyNum(num)}");


// массивы. 
/*
int[] CreateRandomArray(int size, int minValue, int maxValue) //метод 
{
    int[] array = new int[size]; //выделяет в оперативной памяти место

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);

    }
    return array;
}

void ShowArray(int[] array) //следующий метод. выведение массива 
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.Write("Input a size for array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
*/
