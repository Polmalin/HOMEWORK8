// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int [,] InitMatrix ()
{
    int [,] matrix = new int [6, 6];
    int n = matrix.GetLength(0) * matrix.GetLength(1);
    int k = 0;
    int value = 1;
    int iteration=0;
    while (k<n)
    {
        for (int j = iteration; j < matrix.GetLength(1)-iteration && k<n; j++, k++)
        {
            matrix[iteration, j] = value++;
        } 
        for (int i = iteration + 1;i < matrix.GetLength(0)-iteration && k<n; i++, k++)
        {
            matrix[i, matrix.GetLength(1)- iteration - 1] = value++;
        } 
        for (int j = matrix.GetLength(1)-iteration - 2; j >= iteration && k<n; j--, k++)
        {
            matrix[matrix.GetLength(0) - iteration - 1, j] = value++;
        }
        for (int i = matrix.GetLength(0)-iteration - 2; i >= iteration + 1 && k<n; i--, k++)
        {
            matrix[i, iteration] = value++;
        } 
        iteration++;
    }
    return matrix;
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] matrix = InitMatrix();
PrintMatrix(matrix);