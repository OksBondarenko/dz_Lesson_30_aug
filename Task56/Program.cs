//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matr = FillMatrix(m, n, -10, 10);
PrintMatrix(matr);
Console.WriteLine($"{FindMinSum (matr)} строка");

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

int FindMinSum(int[,] matrix)
{
    int result = 0;
    int sumMin = 0;
    int sumCurr = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        sumMin += matrix[0, j];
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumCurr += matrix[i, j];
        if (sumCurr < sumMin)
        {
            sumMin = sumCurr;
            result = i;
        }
        sumCurr = 0;
    }
    return result;
}