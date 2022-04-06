/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
double exponent(double A, double B)
{
    if (B > 0)
    {
        double exp = A;
        for (double count = 2; count <= B; count++)
        {
            exp = exp * A;
        }
        return exp;
    }
    if (B == 0)
    {
        return 1;
    }
    else
    {
        double exp = A;
        for (double count = -2; count >= B; count--)
        {
            exp = 1 / (exp * A);
        }
        return exp;
    }
}

Console.WriteLine("Введите число, которое необходимо возвести в степень ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень, в которую неоюходимо возвести число ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Число " + a1 + " в степени " + b1 + " равно " + exponent(a1, b1));
*/

/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/
/*
int numSum(int num)
{
    int sum = 0;
    int num1 = 1;
    while (num1 > 0)
    {
        num1 = num % 10;
        sum = sum + num1;
        num = num / 10;
    }
    return sum;
}
Console.WriteLine("Введите любое число ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Сумма цифр в числе равна " + numSum(number));
*/

/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
// void eight()
// {
//     Console.WriteLine("Введите элементы массива ");
//     int [] a = new int[8];
//     for(int i = 0; i < 8; i++)
//     {
//         a[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     for(int i = 0; i < 8; i++)
//     {
//         Console.Write(a[i] + " ");
//     }
// }
// eight();
