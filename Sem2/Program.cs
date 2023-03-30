// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

// int CutNumber (int num)
// {
//     int hundreds = num / 100;
//     int unit = num % 10;

//     int result = (num - (hundreds * 100) - unit) / 10;
//     return result;
// }



// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if ( number > 99 && number < 1000)
// {
//     int newNumber = CutNumber(number);
//     Console.WriteLine("Ваше число: " + newNumber);
// }
// else Console.WriteLine("Неверный формат числа");


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int CutNumber1(int num1)
// {
//     if (num1 < 100)
//     {
//         return num1;
//     }
//     else
//     {
//         while (num1 > 1000)
//         {
//             num1 = num1 / 10;
//         }

//         return num1 % 10;
//     }
// }


// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num1 == CutNumber1(num1))
// {
//     Console.WriteLine($"Ваше число {num1} не имеет третьей цифры");
// }
// else
// {
//     Console.WriteLine(CutNumber1(num1));
// }

//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool Div3(int num2)
{
    if (num2 >= 1 && num2 <= 5 || num2 > 7)
    {
        return false;
    }
    else
    {
        return true;
    }
}

Console.Write("Введите день недели: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Div3(num2));