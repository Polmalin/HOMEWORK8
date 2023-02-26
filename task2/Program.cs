// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int GetMinSumRowIndex (int [,] matrix)
{
    int minRowIndex=0;
    int minRowSum=0;
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            sum = sum + matrix [i,j];
        }

        if (i==0 || sum<minRowSum)
        {
            minRowSum=sum;
            minRowIndex=i;
        }
    }
    return minRowIndex;
}

int [,] matrix = InitMatrix();
PrintMatrix(matrix);
Console.WriteLine($"строка с минимальной суммой : {GetMinSumRowIndex(matrix)+1}");
