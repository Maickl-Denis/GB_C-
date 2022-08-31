// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] NewArray(int line, int column) 
{ 
    int[,] array = new int[line, column]; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = new Random().Next(0, 10); 
        } 
    } 
    return array; 
} 
 
void ShowArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
} 
 
void Frequency(int[,] array) 
{ 
    int[,] arrayCalc = new int[2, 10] { { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } }; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            arrayCalc[1, array[i, j]] += 1; 
        } 
    } 
    Console.WriteLine(); 
    ShowArray(arrayCalc); 
} 
 
Console.Write("Количество строк: "); 
int line = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Количество столбцов: "); 
int colums = Convert.ToInt32(Console.ReadLine()); 
int[,] array = NewArray(line, colums); 
ShowArray(array); 
Frequency(array);