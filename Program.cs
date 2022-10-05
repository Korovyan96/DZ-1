void Zadacha41()
{
    Console.WriteLine("Задача № 41 ");
    Console.WriteLine("Введите количество элементов ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] num = new int[n];
    Vvod(num);
    Poisk(num);
}

void Vvod(int[] num)
{
    int i = 0;
    while (i < num.Length)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        num[i] = int.Parse(Console.ReadLine());
        i++;
    }

    for (i = 0; i < num.Length; i++)
    Console.Write("  " + num[i]);
    Console.WriteLine();
       
}

void Poisk(int[] num)
{
    int kol = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            kol++;
        }
    }
    Console.WriteLine("Количество элементов больше нуля  " + kol);
}

void Zadacha43()
{
    Console.WriteLine("Задача № 43 ");
    Console.WriteLine("Введите коэффициент k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);
    Console.WriteLine($"Точка пересечения 2-х прямых:x={x} и y={y}");
}

Zadacha41();
Zadacha43();
