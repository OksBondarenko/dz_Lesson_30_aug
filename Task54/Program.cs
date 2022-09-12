//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matr = FillMatrix(m, n, -5, 10);
PrintMatrix(matr);
Console.WriteLine();
PrintMatrix(Ordering(matr));

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

int[,] Ordering(int[,] matr)
{
    int temp;
    if(matr.GetLength(1) > 1)
        for(int j = 0; j < matr.GetLength(0); j++)
        {
            for(int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                for(int i = 1; i < matr.GetLength(1); i++)
                {
                    if (matr[j, i] < matr[j, i - 1])
                        {
                            temp = matr[j, i];
                            matr[j, i] = matr[j, i - 1];
                            matr[j, i - 1] = temp;
                        }
                }    
            }
        }
    return matr;
}