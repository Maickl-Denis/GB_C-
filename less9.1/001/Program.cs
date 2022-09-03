// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.


Console.Clear();
Console.Write("Введите N: ");

int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(1, n));

string PrintNumbers(int start, int end)
{
    if(start==end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end)) ;
}