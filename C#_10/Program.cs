// Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел 
// (без разделителя). В массиве data хранится информация о количестве бит, 
// которые занимают числа из массива info. Напишите программу, которая составит массив 
// десятичных представлений чисел массива data  с учетом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); 
// третье число занимает 3 бита (000 -> 0); четвертое число занимает 1 бит (1->1).

// Пример:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1}
// info = {2, 3, 3, 1}
// выходные данные:
// 1, 7, 0, 1


int [] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int [] info = {2, 3, 3, 1};

int [] DeciFromBi(int [] dataArray, int[] infoArray)
{
    int [] result = new int [infoArray.Length];
    int dataIndex = 0;
    for (int infoIndex = 0; infoIndex < infoArray.Length; infoIndex++)
    {
        int number = 0;
        int pow = 0;
        for (int i = infoArray[infoIndex]-1; i >= 0; i--)
        {
            number = number + dataArray[dataIndex+i]*(int)Math.Pow(2, pow);
            pow++;
        }
        Console.Write(number+" ");
        dataIndex = dataIndex + infoArray[infoIndex];
        result[infoIndex] = number;
    }
    return result;
}

Console.Write(DeciFromBi(data, info));