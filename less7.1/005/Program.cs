// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Введите количкство строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количкство столбцов массива: ");
int coloms = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, coloms, 0, 9);
PrintArray(array);
diag(array);


void diag(int[,] inArray)
{
    int sum = 0;
    if (inArray.GetLength(0)<inArray.GetLength(1))
    {
        
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, i];
        }
    }
    else
    {
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
            sum += inArray[i, i];
        }
    }
    Console.Write(sum);
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
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}