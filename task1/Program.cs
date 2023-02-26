// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int [,] InitMatrix ()
{
    int [,] matrix = new int [3,4];
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
            Console.Write($"{matrix[i,j]}");
        }
        Console.WriteLine();
    }
}

void sort (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        int r=matrix.GetLength (1)-1;
        bool swapt = true;
        while (swapt) {
            swapt = false;
            for (int j = 0; j < r; j++) {
                if (matrix [i,j] < matrix [i,j+1]) {
                    int tmp = matrix [i,j];
                    matrix [i,j]=matrix [i,j+1];
                    matrix [i,j+1] = tmp;
                    swapt = true;
                }
            }
            r--;
        }
    }
}

int [,] matrix = InitMatrix();
PrintMatrix(matrix);
sort (matrix);
Console.WriteLine();
PrintMatrix(matrix);

