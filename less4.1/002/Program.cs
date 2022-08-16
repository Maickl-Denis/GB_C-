// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

void numbers(int num)
{
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    Console.WriteLine($"В числе {count} цифр");
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

numbers(num);