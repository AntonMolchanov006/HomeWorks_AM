Console.Clear();
//Задача 1: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// Console.WriteLine("Введите размер массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] Array = new int [m,n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Array[i,j] = new Random().Next(10,100);
//     }
// }

// int [,] PrintArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("------------------");
//     return matr;

// }

// int [,] GrowingMatrix(int [,] matr)
// {
//     int temp = matr[0,0];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int l = 0; l < matr.GetLength(1); l++)
//             {
//                 if(matr[i,j] < matr[i,l])
//             {
//                 temp = matr[i,l];
//                 matr[i,l] = matr[i,j];
//                 matr[i,j] = temp;
//             }
//             }

//         }

//     }
//     return matr;
// }
// PrintArray(Array);
//PrintArray(GrowingMatrix(Array));

// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

/*
Console.WriteLine("Введите размер массива: ");
			int x = Convert.ToInt32(Console.ReadLine());
			int y = Convert.ToInt32(Console.ReadLine());


			int min = 10000;

			int minI = 1;
			int[,] Array = new int[x, y];
			for (int i = 0; i < x; i++)
			{
				int sum = 0;

				for (int j = 0; j < y; j++)
				{
					Array[i, j] = new Random().Next(1, 10);
					sum = sum + Array[i, j];
					Console.Write(Array[i, j] + " ");
				}
				Console.Write("-" + sum + "-");
				Console.WriteLine();
				if(sum < min)
				{
					min = sum;
					minI = i;
					
				}
				
			}
			Console.WriteLine("Строка с минимальной суммой: " + (minI + 1));
*/



// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)

/*
int [,,] CubeMatrix = new int [2, 2, 2];
			for(int i = 0; i < 2; i++)
			{
				for(int j = 0; j < 2; j++)
				{
					for(int k = 0; k < 2; k++)
					{
						CubeMatrix[i,j,k] = new Random().Next(10, 100);
                        for(int x=0, y=0, z=0; x<i ||y<j || z<k; x++, y++, z++ )
                        {
                            if(CubeMatrix[i,j,k] == CubeMatrix[x,y,z])
                            {
                                CubeMatrix[i,j,k] = new Random().Next(10, 100);
                            }
                        }
						Console.Write($"{CubeMatrix[i,j,k]} ({i},{j},{k})   ");
					}
					
					Console.WriteLine();
				}
			}
*/

// Задача 4: Заполните спирально массив 4 на 4.

// На выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int[,] Snail = new int[4, 4];
int s = 1;
int j = 0;

for (int i = j; i < 4; i++)
{
    for (j = 0; j < 4; j++)
    {
        Snail[0,j] = s;
        s++;
    }
    for (i = 1; i < 4; i++)
    {
        Snail[i, 3] = s;
        s++;
    }
    for (j = 2; j >= 0; j--)
    {
        Snail[3, j] = s;
        s++;
    }
    for (i = 2; i > 0; i--)
    {
        Snail[i, 0] = s;
        s++;
    }
    for (j = 1; j < 3; j++)
    {
        Snail[1,j] = s;
        s++;
    }
    for(j = 2; j > 0; j--)
    {
        Snail[2, j] = s;
        s++;
    }
    break;

}

int [,] PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("------------------");
    return matr;
}
PrintArray(Snail);