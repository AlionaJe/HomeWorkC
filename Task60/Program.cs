// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)



void FillArray(int[,,] array, int[] Random3dArray)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = Random3dArray[count];
                count++;
            }
}

void RandomArray(int[] Random3dArray)
{
    int num = 0;
    Random3dArray[0] = new Random().Next(10, 100);
    for (int i = 0; i < Random3dArray.Length; i++)
    {
        num = new Random().Next(10, 100);
        if (Random3dArray.Contains(num))
            i--;
        else Random3dArray[i] = num;
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],5} ({i},{j},{k})");
            }
        }
    }
}


Console.Clear();
System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов в глубину: ");
int depth = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[rows, cols, depth];
int[] Random3dArray = new int[rows * cols * depth];

RandomArray(Random3dArray);

FillArray(array, Random3dArray);
PrintArray(array);
