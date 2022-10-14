// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
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
int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            product[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                product[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return product;
}

int a = Prompt("введите число строк в матрице1 ");
int b = Prompt("введите число столбцов в матрице1 ");
int c = Prompt("введите число строк в матрице2 ");
int d = Prompt("введите число столбцов в матрице2 ");
if (!(a > 0 && b > 0 && c > 0 && d > 0))
{
    System.Console.WriteLine("задача не решается");
    return;
}


int[,] array1 = FillArray(a, b);
int[,] array2 = FillArray(c, d);
PrintArray(array1);
System.Console.WriteLine();
PrintArray(array2);
System.Console.WriteLine();
int[,] result = MatrixMultiplication(array1, array2);
PrintArray(result);
