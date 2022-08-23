// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
// Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// void ReversArray(int[] arr)
// {
//     int count = arr.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write(arr[count-1-i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] array = {1, 2, 3, 4, 5};
// ReversArray(array);




// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10
// [1, -5, 8, 4, -9] -> 4.33


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

void SumElem(int[] arr)
{
    double sum = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum += arr[i];
            count ++;
        }
    }
    Console.Write($"{sum/count:F2}");
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
SumElem(myRandomArray);



// x = (b2 - b1) / (k1 - k2);
// y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
