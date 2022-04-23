Console.Clear();
// int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
// int[] info = { 2, 3, 3, 1 };

int[] BinArray(int length)
{

    int[] Array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(0, 2);
    }
    return Array;
}

int[] CodeArray(int size)
{

    int[] Arra = new int[size];
    for (int i = 0; i < size; i++)
    {
        Arra[i] = new Random().Next(1, 4);
    }
    return Arra;
}

int[] PrintArray(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write(ar[i] + " ");
    }
    Console.WriteLine();
    return ar;
}

void DeciToBin(int[] data, int[] info)
{
    int sum = 0;
    for (int i = 0; i < info.Length; i++)
    {
        sum = sum + info[i];
    }

    if (sum <= data.Length)
    {
        int[] ResultArray = new int[info.Length];
        int dataMin = 0;
        int dataMax = 0;
        for (int infoIndex = 0; infoIndex < info.Length; infoIndex++)
        {
            int number = 0;
            int pow = info[infoIndex] - 1;
            dataMax = dataMax + info[infoIndex];
            for (int dataIndex = dataMin; dataIndex < dataMax; dataIndex++)
            {
                number = number + data[dataIndex] * (int)Math.Pow(2, pow);
                pow--;
            }
            dataMin = dataMin + info[infoIndex];
            ResultArray[infoIndex] = number;
            Console.Write(ResultArray[infoIndex] + " ");
        }
    }

    if (sum < data.Length)
    {
        Console.WriteLine("Недостаточно данных");
    }

    if (sum > data.Length)
    {
        int[] ResultArray = new int[info.Length];
        int dataMin = 0;
        int dataMax = 0;
        for (int infoIndex = 0; infoIndex < info.Length-1; infoIndex++)
        {
            int number = 0;
            int pow = info[infoIndex] - 1;
            dataMax = dataMax + info[infoIndex];
            for (int dataIndex = dataMin; dataIndex < dataMax; dataIndex++)
            {
                number = number + data[dataIndex] * (int)Math.Pow(2, pow);
                pow--;
            }
            dataMin = dataMin + info[infoIndex];
            ResultArray[infoIndex] = number;
            Console.Write(ResultArray[infoIndex] + " ");
            int number2 = 0;
            int stepen = info[info.Length-1] - 2;
            for(int dataIndex = data.Length-info[info.Length-1]+1; dataIndex < data.Length; dataIndex++)
            {
                number2 = number2 + data[dataIndex] * (int)Math.Pow(2, stepen);
                stepen--;
            }
            ResultArray[info.Length-1] = number2;
            Console.Write(ResultArray[info.Length-1] + " ");
        }
    }
}

Console.WriteLine("Введите длину массива Data: ");
int len = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер массива Info: ");
int size = Convert.ToInt32(Console.ReadLine());

// PrintArray(BinArray(len));
// PrintArray(CodeArray(size));
Console.WriteLine();
DeciToBin(PrintArray(BinArray(len)), PrintArray(CodeArray(size)));
