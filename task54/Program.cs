// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//метод, который создаст дв.массив
int[,] CreateArray(int row, int col)
{
    return new int[row, col];
}

//метод, который заполняет дв.массив
int[,] Fill(int[,] matrix)
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
string PrintArray(int[,] matrix)
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
void SelectionSort(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)        
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            
            int minPosition = i;
            for(int j = i + 1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
    }
}

int rows = 4;
int columns = 4;
int[,] myMatrix = CreateArray(rows, columns);
Console.WriteLine(PrintArray(Fill(myMatrix)));