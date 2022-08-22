// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void ShowArray2(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void SumNech(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма не четных элементов массива = {sum}");
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите последнее число генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);

ShowArray2(myRandomArray);
SumNech(myRandomArray);