// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void sq3(int x)
{
    int count = 1;
    while (count <= x)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        count++;
    }
}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

sq3(num);