// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}


void ShowArray2(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}

void chetNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"[В массиве {count} четных элементов]");
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
chetNum(myRandomArray);