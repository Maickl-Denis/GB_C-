// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] array = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.Clear();

Console.Write("Введите индекс строки искомого элемента: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите индекс искомого элемента: ");
int coloms = int.Parse(Console.ReadLine());


if (array.GetLength(0)>=rows && array.GetLength(1)>=coloms)
{
    Console.WriteLine($"по индексу [{rows}:{coloms}] расположено число {array[rows, coloms]}");
}
else
{
    Console.WriteLine($"по индексу [{rows}:{coloms}] числа нет");
}