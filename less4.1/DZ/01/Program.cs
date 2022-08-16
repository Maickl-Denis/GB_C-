// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int pw(int num, int pow)
{
    int result = num;
    for (int i = 1; i < pow; i++)
    {
        result *= num;
    }
    return result;
}


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int pow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(pw(num, pow));