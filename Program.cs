void Zadacha47()
{
    Console.WriteLine("Задача № 47 ");
    Console.WriteLine("Введите количество строк ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int m = Convert.ToInt32(Console.ReadLine());
    Random ran = new Random();
    double[,] num = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            num[i, j] = Math.Round(ran.NextDouble() * 20 - 5, 1);
        }
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write(num[i, j] + "\t");
        Console.WriteLine();
    }
}

void Zadacha50()
{
    Console.WriteLine("Задача № 50 ");
    Console.WriteLine("Введите число строк ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] num = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            num[i, j] = new Random().Next(-10, 10);
            Console.Write(num[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Введите строку элемента: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец элемента: ");
    int column = Convert.ToInt32(Console.ReadLine());
    {
        if (row < m && column < n)
            Console.WriteLine("Элемент массива существует " + num[row, column]);
        else
            Console.WriteLine("Элемент массива не существует");
    }
}

void Zadacha52()
{
    Console.WriteLine("Задача № 52 ");
    Console.WriteLine("Введите число строк ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] num = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            num[i, j] = new Random().Next(-10, 10);
            Console.Write(num[i, j] + "\t");
        }
        Console.WriteLine();
    }

    for (int j = 0; j < num.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < num.GetLength(0); i++)
        {
            sum += num[i, j];
        }
        Console.Write($"{Math.Round(sum / num.GetLength(0), 2)}  \t");
    }
}

Zadacha47();
Zadacha50();
Zadacha52();
