//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = FillMatrix(m, n, -10, 10);
int[,] martixB = FillMatrix(n, m, -10, 10);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(martixB);
Console.WriteLine();
PrintMatrix(Multiplication(matrixA, martixB));

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
    Console.WriteLine();
    }
}

int[,] FillMatrix(int rowsCount, int columonsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columonsCount];
    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }

    return matrix;
}

int[,] Multiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int [matrixA.GetLength(1), matrixB.GetLength(0)];
    for (int i = 0; i < result.GetLength(1); i++)
        for (int j = 0; j < result.GetLength(0); j++)
            for (int k = 0; k < result.GetLength(1); k++)
                result[i, j] += matrixA[i, k] * matrixB[k, j];
    return result;
}