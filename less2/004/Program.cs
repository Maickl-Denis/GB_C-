void FillArrey(int[] collection)
{
    int ln = collection.Length;
    int index = 0;
    while (index < ln)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArrey(int[] col)
{
    int count =col.Length;
    int posiion = 0;
    while(posiion < count)
    {
        Console.Write(col[posiion]);
        posiion++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int [] arrey = new int[10];


FillArrey(arrey);
PrintArrey(arrey);
Console.WriteLine();



int pos = IndexOff(arrey, 4);
Console.WriteLine(pos);