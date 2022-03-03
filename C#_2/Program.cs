/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
int noSecond(int number)
{
    if(number > 99 && number < 1000)
    {
        int ost = number % 100;
        return ost / 10;
    }
    else
    {
        return -1;
    }
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая цифра в введённом числе: " + noSecond(num));
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int thirdNum(int number)
{
    if(number > 999)
    {
        while(number > 999)
        {
            number = number / 10;
        }
    }
    return number % 10;
}

Console.WriteLine("Введите любое число ");
int result = Convert.ToInt32(Console.ReadLine());
if(result < 100)
    {
        Console.WriteLine("Третьей цифры нет.");
    }
else
{
    Console.WriteLine("Третья цифра в числе " + result  + " является " + thirdNum(result));
}