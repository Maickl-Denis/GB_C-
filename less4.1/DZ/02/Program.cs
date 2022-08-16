// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += number % 10;
        number /= 10;
    } 
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(GetSumNums(num));