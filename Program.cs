//Задача 64
Console.WriteLine("Задача 64");
int n = InputNumbers("Введите n: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}



//Задача 66
Console.WriteLine($"Задача 66 ");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int t = m;
if (m > n) 
{
  m = n; 
  n = t;
}
PrintSum(m, n, t=0);

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  PrintSum(m, n - 1, sum);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

//Задача 68
Console.WriteLine("Задача 68 ");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int Akkerman = A(m, n);
Console.Write($"Функция Аккермана = {Akkerman} ");

int A(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return A(m - 1, 1);
  else return A(m - 1, A(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
