Console.Clear();
//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void Array(int m, int n)
// {
//     double [,] Array = new double [m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Array[i,j] = Math.Round(new Random().NextDouble()*100, 1);
//             Console.Write(Array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }
// Console.Write("Введите количество строк: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Array(numM, numN);

//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.



// int[,] NewArray = new int[6, 7];
// for (int i = 0; i < 6; i++)
// {
//     for (int j = 0; j < 7; j++)
//     {
//         NewArray[i, j] = new Random().Next(1, 100);
//         Console.Write(NewArray[i, j] + " ");
//     }
//     Console.WriteLine();
// }



// void SearchElement(int[,] otherArray, int x, int y)
// {
//     if (x < otherArray.GetLength(0) && y < otherArray.GetLength(1)) 
//     Console.WriteLine("Искомый элемент: " + otherArray[x, y]);
//     else Console.WriteLine("Такого элемента не существует.");
// }



// Console.Write("Введите номер строки: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите ршмер столбца: ");
// int B = Convert.ToInt32(Console.ReadLine());


// SearchElement(NewArray, A, B);


//Задача 3. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// void Average(int row, int column)
// {
//     int i;
//     int j;

//     int [,] Matrix = new int [row, column];
//     for (i = 0; i < row; i++)
//     {
//         for (j = 0; j < column; j++)
//         {
//             Matrix[i, j] = new Random().Next(1,10);
//             Console.Write(Matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     for (j = 0; j < column; j++)
//     {
//         double result = 0;
//         for (i = 0; i < row; i++)
//         {
//             result = (result + Matrix[i,j]);
//         }

//         Console.Write(Math.Round(result/row, 2) + " ");
//     }
// }
// Console.Write("Введите количество строк: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int numN = Convert.ToInt32(Console.ReadLine());

// Average(numM, numN);