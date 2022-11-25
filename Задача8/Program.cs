Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

int i = 0;
int a = 0;
Console.Write("Четные: ");

while (i <= n)
{
    if (i % 2 == 0)
   {
     a = i;
     if (a == 0)
     {
      i++;
     }
     else
    Console.Write($"{a} ");
    i++;
   }
else
i++;
}
