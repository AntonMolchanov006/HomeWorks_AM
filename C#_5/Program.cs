﻿// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
void Checking()
{
    int[] a = new int[10];
    int count = 0;
    for (int i = 0; i < 10; i++)
    {
        a[i] = new Random().Next(100, 1000);
        Console.Write(a[i] + " ");

        if (a[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Колисество четных чисел в массиве равно: " + count);
}
Checking();
*/

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int Summa()
{
    int[] array = new int[10];
    int sum = 0;
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(-100, 101);
        Console.Write(array[i] + " ");

        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine();
    return sum;
}
Console.WriteLine("Сумма элементов с нечетным индексом равна: " + Summa());
*/

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Difference()
{
    int [] array = new int [10];
    int max = 0;
    int min = 100;
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] +" ");
        if(array[i] > max)
        {
             max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    int dif = max - min;
    Console.WriteLine();
     Console.WriteLine("максимум: " + max);
     Console.WriteLine("минимум: " + min);

    return dif;
}
Console.WriteLine($"Разница между максимальным числом и минимальным равна {Difference()}");