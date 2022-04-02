// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
void PositiveNumbers()
{
    Console.WriteLine("Введите количество вводов: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i <= M - 1; i++)
    {
        Console.WriteLine("Введите любое число:");
        int number = Convert.ToInt16(Console.ReadLine());
        if (number > 0) count = count + 1;
    }
    Console.WriteLine("Количество положительных чисел равно: " + count);
}
PositiveNumbers();
*/

// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1

void Frame()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] frameArray = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (j == 0 || j == m - 1 || i == 0 || i == n - 1) frameArray[i, j] = 1;
            else frameArray[i, j] = 0;
            Console.Write(frameArray[i, j] + " ");
        }
        Console.WriteLine();
    }

}
Console.WriteLine("Enter array size ");
Frame();