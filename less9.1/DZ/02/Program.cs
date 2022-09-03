// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите М: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(n, m));

int PrintNumbers(int n, int m)
{
    
    if(n==m+1) return 0;
    return n + PrintNumbers(n+1, m);
}