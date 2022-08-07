int [] array = {1, 12, 18, 31, 4, 15, 16, 17, 18};

int len = array.Length;
int find = 18;

int index = 0;

while (index < len)
{
    
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


