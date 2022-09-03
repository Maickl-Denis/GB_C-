// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Clear();
Console.Write("Введите число: ");

int n = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(n));
int PrintNumbers(int n)
{
    if(n %10 == 0) return 0;
    return(n % 10 + PrintNumbers(n/10));
}

