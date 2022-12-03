// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//метод, который создаёт двумерный массив
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}
    
//метод, который заполняет двумерный массив
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

//метод суммы элементов каждой строчки дв.массива
int[] SumArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
  
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        array[i] = sum;
    }
    return array;
}

//метод нахождения строки с наименьшей суммой элементов
int MinSum(int[] array)
{
    int min = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if (array[min] > array[i]) min = i;
    }
    return min;
}

    
int rows = 4;       
int columns = 6;    
int[,] myMatrix = CreateMatrix(rows, columns);
Console.WriteLine(PrintMatrix(FillMatrix(myMatrix)));
Console.WriteLine($"Строка с наименьшей суммой элементов: {MinSum(SumArray(myMatrix))+1}");
