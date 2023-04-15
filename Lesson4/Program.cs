/*
string[,] table = new string[2, 5];
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/
/*
int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}    
*/
//команда matrix.GetLength(0), здесь будет равняться 3 строкам,
// а команда matrix.GetLength(1), количествам столбцов, т.е. 4.

/*
void PrintArray(int[,] matr)
{

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
Console.WriteLine();
}    

}

void FillArray(int[,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10); 
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

//как представить черно-белое изображение: 
// int[,] pic = new int[23, 25];
// 0 - закрашенный пиксель
// 1 - незакрашенный пиксель