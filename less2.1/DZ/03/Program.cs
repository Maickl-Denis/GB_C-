// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write($"Введите цыфру соответствующую дню недели: ");
int day = Convert.ToInt32(Console.ReadLine());

int result = day % 7;


switch (result)
{
    case 1: Console.Write($"{day} является понедельником"); break;
    case 2: Console.Write($"{day} является вторником"); break;
    case 3: Console.Write($"{day} является средой"); break;
    case 4: Console.Write($"{day} является четвергом"); break;
    case 5: Console.Write($"{day} является пятницей"); break;
    case 6: Console.Write($"Ура {day} является субботним выходным"); break;
    case 0: Console.Write($"Ура {day} является воскресным выходным"); break;
    default: break;
}
