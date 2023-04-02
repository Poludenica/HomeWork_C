// // Методы 4х типов:
// 1 Метод ничего не принимает и ничего не возвраащает. Тип void 
// 2 метод принимает какие-то данные, но не возвращает. Тип void
// 3 метод ничего не принимает, но возвращает значения.
// 4 метод принимает аргументы и возвращает значения.

// Цикл for. Это цикл со счетчиком. 

// for(int i = 0, i < 10, i++)
// {
//     Console.WriteLine(i)
// }

// string Method4(int count, string text)
// {

//     string result = String.Empty; //чтобы все видели, что строка пуста
//     for( int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);


// Цикл внутри цикла. 
// Классическая задача - вывод таблицы умножения на экран:
// for( int i = 2; i <= 10; i++)
// {
//     for ( int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine(); // переход на новую строку
// }

// Задача 1. В тексте все пробелы нужно заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С", заменить маленькими "с". 

// string text = " - Я думаю, - сказал князь, улыбаясь, - что,"
            // + "ежели бы вас послали вместо нашего милого ВИнценгероде,"
            // + "вы бы взяли приступом согласие прусского короля. "
            // + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             01234
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length; //свойство показывающее количество символов строки
//     for( int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}"; // если символ совпал с тем, что нам нужен то в резалт кладется новый символ
//         else result = result + $"{text[i]}"; //то оставляем в таком же виде
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|'); //аргументы, что заменить пробелы на черточки

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();

// Задача 2. Упорядочивание массива. Алгоритм сортировки методом выбора, алгоритм выбора мин и макс. 
// 1. Найти позицию мин элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы.

// int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}, "); //вывод самого массива на экран
//     }
//     Console.WriteLine();
// }
// void SelectionSort( int[] array)
// // метод который будет упорядочивать массив
// {
//     for (int i = 0; i < array.Length - 1 /* искуственно отнимаем 1 чтобы в цикле j было максимальное кол-во элементов*/; i++)
//     {
//         int minPossition = i;
        
//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPossition]) minPossition = j;
        
//         }

//         int temporary = array[i];
//         array[i] = array[minPossition];
//         array[minPossition] = temporary;


//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

// упорядочивание в обратном порядке
/*
int [] arr = { 1, 7, 1, 8, 6, 5};
void printArray (int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
void SelectionSort (int[] array)
{
    for ( int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for(int j = i; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array [maxPosition];
        array[maxPosition] = temporary;
    }
}
printArray(arr);
SelectionSort(arr);
printArray(arr);
*/