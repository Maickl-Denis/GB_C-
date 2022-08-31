// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количкство строк массива 1: ");
int rows1 = int.Parse(Console.ReadLine());

Console.Write("Введите количкство столбцов массива 1: ");
int coloms1 = int.Parse(Console.ReadLine());

Console.Write("Введите количкство строк массива 2: ");
int rows2 = int.Parse(Console.ReadLine());

Console.Write("Введите количкство столбцов массива 2: ");
int coloms2 = int.Parse(Console.ReadLine());

if(coloms1 == rows2)
{
    int[,] array1 = GetArray(rows1, coloms1, 0, 10);
    int[,] array2 = GetArray(rows2, coloms2, 0, 10);
    PrintArray(array1);
    PrintArray(array2);
    marix(array1, array2);
}
else
{
    Console.WriteLine(" Матрицы нельзя перемножить");
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++ )
    {
        Console.Write($"{i+1}: ");
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void marix(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i,j] += a[i,k] * b[k,j];
            }
        }
    }
    PrintArray(r);
}