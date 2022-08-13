// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void RastoznieKoord(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double ABx = Math.Pow((Ax - Bx), 2);
    double ABy = Math.Pow((Ay - By), 2);
    double ABz = Math.Pow((Az - Bz), 2);
    Console.WriteLine($"d={Math.Sqrt((ABx+ABy+ABz)):f2}");
}

RastoznieKoord(3, 6, 8, 2, 1, -7);
RastoznieKoord(7, -5, 0, 1, -1, 9);
