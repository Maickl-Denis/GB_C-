// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// K1*x+ b1 = k2*x +b2
// (K1-k2)*x  = b2 - b1
// X= (b2-b1) / (k1 -k2)
// y = k1 * x + b1

Console.WriteLine($"Введите точку 1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите точку 2");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите точку 3");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите точку 4");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"точка пересечения двух прямых ({(b2-b1) / (k1 -k2)}; {(k1 *((b2-b1) / (k1 -k2))) + b1})");
