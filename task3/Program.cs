// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int [,] InitMatrix ()
{
    int [,] matrix = new int [3,3];
    Random rnd = new Random ();

    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            matrix [i,j] = rnd.Next(1,10);
        }
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

int [,] Multiply(int [,] a, int [,] b)
{
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                result[i,j] += a[i,k] * b[k,j];
            }
        }
    }
    return result;
}

int [,] a = InitMatrix();
PrintMatrix(a);
Console.WriteLine();
int [,] b = InitMatrix();
PrintMatrix(b);
Console.WriteLine("Результат произведения матриц:");
PrintMatrix(Multiply(a,b));
