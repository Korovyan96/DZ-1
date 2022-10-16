void Zadacha54()
{
    Console.WriteLine("Задача № 54 ");
    Console.WriteLine("Введите количество строк ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int m = Convert.ToInt32(Console.ReadLine());
    Random ran = new Random();
    int[,] num = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            num[i, j] = ran.Next(0,20);
        }
    }
    PrintArray(num);
    Sort(num);
    PrintArray(num);
}

void PrintArray(int [,]num)
{
 for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
            Console.Write(num[i, j] + "\t");
        Console.WriteLine();
    }
}
void Sort(int[,]num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1)-1; j++)
             {
               for (int b = 0; b < num.GetLength(1)-1; b++)
                {
                    if ((num[i,b] < num[i,b+1])) 
                         { int t=0;
                           t = num[i,b];
                           num[i,b] = num[i,b+1];
                           num[i,b+1] = t;
                         }
                 }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив с упорядоченными значениями");
            }
    
 
void Zadacha56()
{
    Console.WriteLine("Задача № 56 ");
    int n = 3;
    int m = 4;
    int[,] num = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            num[i, j] = new Random().Next(-10, 10);
        }
    }
    PrintArray(num);
    Poisk(num);
}

void Poisk(int[,]num)
{
int minsum = 0;
int index = 0;

for (int i = 0; i < num.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < num.GetLength(1); j++)
    {
        sum = sum + num[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        index++;
    }
}

Console.WriteLine("Cтрока с наименьшей суммой элементов под номером: " + (index) + ", с суммой элементов равной: " + (minsum));
}


void Zadacha58()
{
    Console.WriteLine("Задача № 58 ");
    Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[size, size];
int n = 1;
int i = 0;
int j = 0;

while (n <= size * size)
{
    num[i, j] = n;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++n;
}
PrintArray(num);
}

Zadacha54();
Zadacha56();
Zadacha58();

