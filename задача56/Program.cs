// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0)
{
    int[,] matrix = new int[numLine, numColumns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minRand, maxRand);
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}
int[] SumOfLine(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
    }

    return sum;
}
void ArrayPrint(int[] myArr)
{
    for (int j = 0; j < myArr.Length; j++)
    {
        System.Console.Write($"{myArr[j]}\t  ");
    }
}
int MinIndex(int[] array)
{
    int minNum = array[0];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] < minNum)
        {
            minNum = array[i];
            index = i;
        }
    }
    return index;
}
int[,] matrix = FillArray(3, 4);
PrintArray(matrix);
System.Console.WriteLine();
int[] sum = SumOfLine(matrix);
ArrayPrint(sum);
System.Console.WriteLine();
System.Console.WriteLine($"наименьшая сумма элементов в {MinIndex(sum) + 1} строке");
