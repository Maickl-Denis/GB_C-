// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//1 2 3  1 4 7
//4 5 6  2 5 8
//7 8 9  3 6 9

Console.Write("Введите количкство строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количкство столбцов массива: ");
int coloms = int.Parse(Console.ReadLine());

if(rows == coloms)
{
    int[,] array = GetArray(rows, coloms, 0, 10);
    PrintArray(array);
    ChangeArray(array);
}
else
{
    Console.WriteLine("массив нельзя измеить");
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

void ChangeArray(int[,] array)
{
    int[,] newArray = new int [array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j, i] = array[i, j];
        }
    }

    PrintArray(newArray);
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
    Console.WriteLine();
}