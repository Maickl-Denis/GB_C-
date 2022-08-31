// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int minValue, int maxValue)
{
    int[,] result = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
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

void magicMethod(int[,] array)
{
    int[] result = {9999, 0};
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           sum += array[i, j];
        }
        if (result[0] == 9999) result[0] = sum;
        else
        {
            if(result[0]>sum)
            {
                result[0] = sum;
                result[1] = i+1;
            }
        }
        sum = 0;
    }
    Console.Write($"в строку {result[1]} минимальная сумма элементов {result[0]}");
}


Console.Write("Введите количкство велечину массива: ");
int mass = int.Parse(Console.ReadLine());

int[,] array = GetArray(mass, 0, 9);
PrintArray(array);
magicMethod(array);