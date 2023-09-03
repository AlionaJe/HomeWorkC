// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0,10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        Console.WriteLine();
        }
}

int[] SumRowsArray(int[,] array, int rows)
{
    int [] summaRows = new int[rows];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
            sum = sum + array[i, j];
            }
        summaRows [i] = sum;
        }
    return summaRows;
}

int MinRows(int[] SumRows)
{
    int iMin = 0;
    for (int i = 0; i < SumRows.Length-1; i++)
    {
        for (int j = i+1; j < SumRows.Length; j++)
        {
            if (SumRows[j]<SumRows[iMin])
                iMin = j;
        }
    }
    return iMin;
}



Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
int[] SumRows = SumRowsArray(array, rows);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в {MinRows(SumRows)} строке");