/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int secNum(int number)
{
    if (number > 99 && number < 1000)
    {
        int ost = number % 100;
        return ost /10;
    }
    else
    {
        Console.WriteLine("Ваше число не подходит под условие задачи.");
    }
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая цифра в введённом числе: " + secNum);

