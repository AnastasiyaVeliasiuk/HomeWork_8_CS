// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
//строки двумерного массива.

/*void FillandPrintArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 5);
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortString(int[,] matrix2, int numberString)
{
    for (int i = 0; i < matrix2.GetLength(1); i++)
    {
        int indexMax = i;
        int max = matrix2[numberString, i];
        for (int j = i + 1; j < matrix2.GetLength(1); j++)
        {
            if (matrix2[numberString, j] > max)
            {
                max = matrix2[numberString, j];
                indexMax = j;
            }
        }
        int help = matrix2[numberString, indexMax];
        matrix2[numberString, indexMax] = matrix2[numberString, i];
        matrix2[numberString, i] = help;
    }
}

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        SortString(matrix, i);
    }
}

int[,] myMatrix = new int[5, 7];
FillandPrintArray(myMatrix);
SortMatrix(myMatrix);
Console.WriteLine();
PrintArray(myMatrix);*/



//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с
//наименьшей суммой элементов.

/*void FillandPrintArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumString(int[,] matrix2, int numString)
{
    int sumString = 0;
    for (int i = 0; i < matrix2.GetLength(1); i++)
    {
        sumString = sumString + matrix2[numString, i];
    }
    return sumString;
}

int MinSumString(int[,] matrix)
{
    int minSum = SumString(matrix, 0);
    int minSumIndex = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int s = SumString(matrix, i);
        if (s < minSum)
        {
            minSum = s;
            minSumIndex = i;
        }
    }
    return minSumIndex;
}
int[,] myMatrix = new int[5, 7];
FillandPrintArray(myMatrix);
int minIndex = MinSumString(myMatrix);
Console.WriteLine($"Строка {MinSumString(myMatrix)} имеет минимальную сумму");*/




//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*int[,] CreateandPrintArray(int n, int m)
{
    int[,] matrix1 = new int[n, m];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix1;
}

int[,] MultiplyMatrices(int[,] m1, int[,] m2)
{
    int[,] mm = new int[m1.GetLength(0), m2.GetLength(1)];
    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m2.GetLength(0); j++)
        {
            mm[i, j] = 0;
            for (int k = 0; k < m1.GetLength(1); k++)
            {
                mm[i, j] = mm[i, j] + m1[i, k] * m2[k, j];
            }
        }
    }
    return mm;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] m1 = CreateandPrintArray(new Random().Next(1, 10), 5);
int[,] m2 = CreateandPrintArray(5, new Random().Next(1, 10));
PrintArray(MultiplyMatrices(m1, m2));*/


