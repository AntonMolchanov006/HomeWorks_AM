/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("Большее число: " + a + ", а меньшее:" + b);
}
else
{
    Console.WriteLine("Большее число: " + b + ", а меньшее:" + a);
}
*/

/*
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());


if(a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимальное число: " + a);
    }
    else
    {
        if (c > b)
        {
            Console.WriteLine("Максимальное число: " + c);
        }
        else
        {
            Console.WriteLine("Максимальное число: " + b);
        }
    }
}
*/

/*
Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
*/

/*
Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите любое натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= N)
{
    if (a % 2 == 0)
    {
        Console.WriteLine(a);
        a += 1;
    }
    else
    {
        a += 1;
    }
}


