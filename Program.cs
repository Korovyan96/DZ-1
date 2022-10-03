
void Zadacha34()
{
    Console.WriteLine("Задача №34 ");
    int k = 0;
    int[] num = new int[5];
    Random ran = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = ran.Next(100, 1000);
        Console.Write(num[i] + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] % 2 == 0)
        {
            k++;
        }
    }
    Console.WriteLine("Количество четных чисел: " + k);
}



void Zadacha36()
{
    Console.WriteLine("Задача № 36 ");
    int sum = 0;
    int[] num = new int[7];
    Random ran = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = ran.Next(-10, 20);
        Console.Write(num[i] + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < num.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + num[i];
        }
    }
    Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
}



void Zadacha38()
{
    Console.WriteLine("Задача № 38 ");
    int size = 8;
    int min = 0;
    int max = 0;
    double raz = 0;
    Random ran = new Random();
    double[] num = new double[size];
    int i;
    for (i = 0; i < size; i++)
    {
        num[i] = Math.Round(ran.NextDouble() * 20, 2);
        Console.Write(num[i] + "\t");
    }
    Console.WriteLine();
    
    for (i = 0; i < size; i++)
        if (num[i] < num[min])
        {
            min = i;
        }
        else if (num[i] > num[max])
        {
            max = i;
        }
    raz = Math.Round(num[max] - num[min],2);
    Console.WriteLine("Разница между max и min " + raz);
    Console.WriteLine();
}






Zadacha34();
Zadacha36();
Zadacha38();


