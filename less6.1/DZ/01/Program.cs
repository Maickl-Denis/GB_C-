// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] RandomArray = new int[size];   
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} число");
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return RandomArray;
}
void CountD(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >0)
        {
            count++;
        }
    }
    Console.WriteLine($"В введенных числах {(String.Join(", ", arr))} находится {count} положительных цифр");
}

Console.Clear();
int[] myArray = CreateArray();
CountD(myArray);
