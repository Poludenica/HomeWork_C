 
 //Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 //N = 5. -> "5, 4, 3, 2, 1"
 //N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
 
 /*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

ReductionNum(num, count);


void ReductionNum(int num, int count)
{
    if (count > num)
    {
        return;
    }
    else
    {
        ReductionNum(num, count + 1);
        Console.Write(count + ", ");
    }
}
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
 /* 
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumNumMToN(m, n);

void SumNumMToN(int m, int n)
{
   Console.Write(SumNum(m - 1, n));
}

int SumNum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumNum(m, n);
        return res;
    }
}
*/

//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29
 
 /*
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

void AkkermanFunction(int m, int n)
{
    Console.Write("Result is " + Akkerman(m, n)); 
}
*/

