// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArray(int[,] array, int rows, int cols)
{
    int count = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == rows - 4 && j <= array.GetLength(1))
            {
                array[i,j] = count;
                count++;
            }
            else if (i <= array.GetLength(0) && j == cols - 1)
            {
                array[i,j] = count;
                count++;
            }
        }
    }
    for (int i = 3; i > rows - 4; i--)
    {
        for (int j = 3; j >= cols - 4; j--)
        {
            if (i == rows - 1 && j < array.GetLength(1)-1)
            {
                array[i,j] = count;
                count++;
            }
            else if (i < array.GetLength(0) && j == cols - 4)
            {
                array[i,j] = count;
                count++;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == rows - 3 && j > cols - 4 && j < cols - 1)
            {
                array[i,j] = count;
                count++;
            }
        }
    }
    for (int i = 3; i > rows - 4; i--)
    {
        for (int j = 3; j >= cols - 4; j--)
        {
            if (i == rows - 2 && j > cols - 4 && j < cols - 1)
            {
                array[i,j] = count;
                count++;
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j],3}  ");
            }
            Console.WriteLine();
        }
}



Console.Clear();
int rows = 4;
int cols = 4;
int[,] array = new int [rows, cols];
FillArray(array, rows, cols);
Console.WriteLine($"Спирально заполненый массив 4 х 4: ");
PrintArray(array);