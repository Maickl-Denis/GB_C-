// Задача 32: Напишите программу замена элементов массива: положительные элементы заменить на соответствующие отрицательные, и наоборот
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] absRevers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}


int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] RandomArray = new int[size];   
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return RandomArray;
}

void ShowArray2(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}

int[] arr = CreateArray();
ShowArray2(arr);
ShowArray2(absRevers(arr));
