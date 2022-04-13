Console.Clear();


int[,] CreateTriangle(int size)
{
    int[,] Triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        Triangle[i, 0] = 1;
        Triangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            Triangle[i, j] = Triangle[i - 1, j - 1] + Triangle[i - 1, j];
        }
    }
    return Triangle;
}

void PrintPascal(int[,] matr)
{
    int x = Console.WindowWidth / 2;
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.SetCursorPosition(x, i);
        
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > 0)
            {
                Console.Write(matr[i, j] + " ");
                
            }
        }
        x--;
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Введите размер треугольника Паскаля: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintPascal(CreateTriangle(N));