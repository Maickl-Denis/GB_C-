// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomArray(int N)
{
    Random random = new Random();
    double[] RandomArray = new double[N];
    double max = 0;
    double min = 0;
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = random.NextDouble() * 100;
    }
    return RandomArray;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2} ");
    }
    Console.WriteLine("");
}

void MaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
            {
                max = array[i];
            }
        if (min > array[i])
            {
                min = array[i];
            }
    }
    Console.WriteLine($"{(max-min):f2}");
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int num = Convert.ToInt32(Console.ReadLine());

double[] myRandomArray = CreateRandomArray(num);
ShowArray(myRandomArray);
MaxAndMin(myRandomArray);

