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

int[] DeciToBin(int[] data, int[] info)
{
    int[] ResultArray = new int[info.Length];
    int dataMin = 0;
    int dataMax = 0;
    
    for (int infoIndex = 0; infoIndex < info.Length; infoIndex++)
    {
        
        
        int number = 0;
        int pow = info[infoIndex] - 1;
        dataMax = dataMax + info[infoIndex];
        // for (int i = info[infoIndex] - 1; i >= 0; i--)
        // {
        //     number = number + data[dataIndex + i] * (int)Math.Pow(2, pow);
        //     pow++;
        // }

        for (int dataIndex = dataMin; dataIndex < dataMax; dataIndex++)
        {
            number = number + data[dataIndex] * (int)Math.Pow(2, pow);
            pow--;
        }
        
        dataMin = dataMin + info[infoIndex];
        
        ResultArray[infoIndex] = number;
        Console.Write(ResultArray[infoIndex] + " ");

    }

    return ResultArray;
}

Console.WriteLine("Введите длину массива Data: ");
int len = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер массива Info: ");
int size = Convert.ToInt32(Console.ReadLine());

// PrintArray(BinArray(len));
// PrintArray(CodeArray(size));
Console.WriteLine();
DeciToBin(PrintArray(BinArray(len)), PrintArray(CodeArray(size)));
