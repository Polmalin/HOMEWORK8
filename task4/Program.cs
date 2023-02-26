// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int [, ,] InitMatrix ()
{
    int [] values = new int [8];
    int valueIndex=0;
    int [,,] matrix = new int [2,2,2];
    Random rnd = new Random ();

    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            for (int k = 0; k < matrix.GetLength (2); k++)
                {
                    while (true)
                    {
                        int value = rnd.Next(10,18);
                        if (!Find (value, values, valueIndex))
                        {
                            matrix [i,j,k] = value;
                            values[valueIndex]=value;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"found {value}");
                        }
                    }
                    valueIndex++;
                }
        }
    }
    return matrix;
}

void PrintMatrix (int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            for (int k = 0; k < matrix.GetLength (2); k++)
            {
                Console.Write($"{matrix[i,j,k]} {(i,j,k)}");
            }
        }
        
        Console.WriteLine();
    }
}


bool Find ( int value, int [] values, int valueIndex)
{
    for (int i = 0; i < valueIndex; i++)
    {
        if(value==values[i])
        {
            return true;
        }
    }
    return false;
}

int [, ,] matrix = InitMatrix();
PrintMatrix(matrix);