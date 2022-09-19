//Заполните спирально массив 4 на 4.

int[,] array = new int[4,4];

void Spiral(int [,] array, int i, int j, int k)
{
    for (int l = 0; l < 2; l++)
    {
        for (;j < 3 - l; j++, k++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = k;
            }
        }
        for (;i < 3 - l; i++, k++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = k;
            }
        }
        for (;j > 0 + l; j--, k++)
        {
            if (array[i, j] == 0)
            {
            array[i, j] = k;
            }
        }
        for (;i > 1 + l; i--, k++)
        {
            if (array[i, j] == 0)
            {
            array[i, j] = k;
            }
        }
    }
    if (array[i, j] == 0)
    array[i, j] = k;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 10)
            {
              Console.Write("0" + matrix[i,j] + " ");  
            }
            else
            {
                Console.Write(matrix[i,j] + " ");
            }
        }
    Console.WriteLine();
    }
}

Spiral(array, 0, 0, 1);
PrintMatrix(array);