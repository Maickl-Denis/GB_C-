string[,] table = new string[2, 5];
table[1, 2] = "слово";

for (int rows = 0; row < 2; rows++)
{
    for (int col = 0; col < 5; col++)
    {
        Console.WriteLine($"{table{rows, col}}");
    }
}