void koord(int x, int y)
{
    if (x > 0 && y >    0)
        {Console.WriteLine("Первая четверть");}
    else if (x > 0 && y < 0)
        {Console.WriteLine("четвертая четверть");}
    else if (x < 0 && y < 0)
        {Console.WriteLine("третья четверть");}
    else if (x < 0 && y > 0)
        {Console.WriteLine("Вторая четверть");}
    else
        {Console.WriteLine("вне четвертей");}
}




// Console.Write("введите точко Х ");
// int numX = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите точко Y ");
// int   numY = Convert.ToInt32(Console.ReadLine());
// koord(numX, numY);

void koord1(int x)
{
    if (x == 1)  
        {Console.WriteLine("x > 0 и y > 0");}
    else if (x == 4)
        {Console.WriteLine("x > 0 и y < 0");}
    else if (x == 3)
        {Console.WriteLine("x < 0 и y < 0");}
    else if (x == 2)
        {Console.WriteLine("x < 0 и y > 0");}
    else
    {Console.WriteLine("такой четверти координат нет");}
}

// koord1(Convert.ToInt32(Console.ReadLine()));


void RastoznieKoord(int Ax, int Ay, int Bx, int By)
{
    double ABx = Math.Pow((Ax - Bx), 2);
    double ABy = Math.Pow((Ay - By), 2);
    Console.WriteLine($"d={Math.Sqrt((ABx+ABy)):f2}");
}

RastoznieKoord(3, 6, 2, 1);
// A (7,-5); B (1,-1) -> 7,21
RastoznieKoord(7, -5, 1, -1);



void sq(int x)
{
    int count = 1;
    while (count <= x)
    {
        Console.Write($"{Math.Pow(count, 2)} ");
        count++;
    }
}

// sq(5);