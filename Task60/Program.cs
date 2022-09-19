//Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите l: ");
int l = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,,] matr = FillMatrix(l, m, n, 10, 100);
PrintMatrix(matr);


void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i,j,k]} ({i}, {j}, {k}) ");
            }
        }
    Console.WriteLine();
    }
}

int[,,] FillMatrix(int rowsCount, int columonsCount, int depthCount, int leftRange, int rightRange)
{
    int[,,] matrix = new int[rowsCount, columonsCount, depthCount];
    int[] uniqValue = new int[90];
    int value;
    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                do
                    value = rand.Next(leftRange, rightRange);
                    while (value == uniqValue[value - 10]);
                    uniqValue[value - 10] = value;
                    matrix[i, j, k] = value;
            }
        }
    }
    return matrix;
}

