// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num1 = new Random().Next(-10000,10000);
// int num1 = -998;

Console.WriteLine($"На вход пришло число: {num1}");
num1 = Math.Abs(num1);
if (num1 < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (num1 >= 1000) 
    {
        num1 /= 10;
    }
    int d = num1 % 10;
    Console.WriteLine(d);
}
