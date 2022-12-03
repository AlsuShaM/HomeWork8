// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

//метод, который создаст дв.массив
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}

//метод, который заполняет дв.массив
int[,] FillMatrix(int[,] matrix)
{
    int min = 1;
    int max = 10;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

//метод печати дв.массива
string PrintMatrix(int[,] matrix)
{
    string result = string.Empty;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            result += $"{matrix[i,j],3}";
        }
    result += "\n";
    }
return result;
}

//метод, который упорядочит каждую строку дв.массива
int[,] SelectionSort(int[,] matrix)
{
    int temporary = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)        
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int n = 0; n < matrix.GetLength(1)-1; n++)
            {
                if(matrix[i, n] > matrix[i, n+1])
                {
                    temporary = matrix[i, n];
                    matrix[i, n] = matrix[i, n + 1];
                    matrix[i, n + 1] = temporary;
                }
            }
        }
    }
    return matrix;
}

int rows = 4;
int columns = 4;
int[,] myMatrix = CreateMatrix(rows, columns);
Console.WriteLine(PrintMatrix(FillMatrix(myMatrix)));
Console.WriteLine(PrintMatrix(SelectionSort(myMatrix)));