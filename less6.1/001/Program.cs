int[,] array = new int[3, 4]
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

Console.WriteLine("Колличество строк: " + array.GetLength(0));
Console.WriteLine("Колличество столбцов: " + array.GetLength(0));

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


