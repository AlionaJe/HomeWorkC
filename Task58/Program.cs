// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 5);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}  ");
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] array, int[,] array2, int rows, int cols)
{
    int[,] Matrix = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                Matrix[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    return Matrix;
}


Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
int[,] array2 = new int[rows, cols];

FillArray(array);
PrintArray(array);
Console.WriteLine();

FillArray(array2);
PrintArray(array2);
Console.WriteLine();
int[,] Matrix = MultiplyMatrix(array, array2, rows, cols);
Console.WriteLine("Результирующая матрица:");
PrintArray(Matrix);