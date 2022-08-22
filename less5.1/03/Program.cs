// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

void FindNum(int num, int[] array)
{
    String result = "Нет";
    for (int i = 0; i < array.Length; i++)
    {
        if(i == num)
        {
            result = "Да";
            break;
        }
    }
    Console.WriteLine(result);
}

int[] arr = CreateArray();
Console.WriteLine("Введите число которое ищем в массиве");
int num = Convert.ToInt32(Console.ReadLine());
FindNum(num, arr);