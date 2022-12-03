// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2


//метод, который создаёт трёхмерный массив
int[,,] CreateMatrix(int x, int y, int z)
    {
        return new int[x,y,z];
    }

//метод, который заполняет трёхмерный массив
int[,,] FillMatrix(int[,,] matrix)
{
    int min = 10;
    int max = 100;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
               matrix[i,j,k] = new Random().Next(min, max); 
            }
        }
    }
    return matrix;
}

//метод печати трёхмерного массива
string PrintMatrix(int[,,] matrix)
{
    string result = string.Empty;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                result += $"{matrix[i,j,k],4} ({i},{j},{k})";
            }
            result += "\n";
        }
    }
return result;
}

int x = 2;        
int y = 2;
int z = 2;
int[,,] myMatrix = CreateMatrix(x,y,z);
Console.WriteLine(PrintMatrix(FillMatrix(myMatrix)));
