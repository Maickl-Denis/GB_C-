// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.Clear();
PrintArray(array);
sortMass(array);


int[,] sortMass (int[,] array)
{
    int[] newArray = new int [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j] = array[i, j];
        }
        Array.Sort(newArray);
        Array.Reverse(newArray);
        PrintArray1(newArray);
    }

return array;
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

void PrintArray1(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++ )
    {

        Console.Write($"{inArray[i]} ");

    }
    Console.WriteLine();
}

void newSort (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = 0; t < array.GetLength(1); t++)
            {
                if (array[i, t] > array[i, j])
                {
                    int temp = array [i, j];
                    array[i, j] = array [i, t];
                    array [i, t] = temp;
                }
            }
        }
    }
}