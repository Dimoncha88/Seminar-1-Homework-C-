// Задача 2

Console.WriteLine("Введите первое число: ");
int NumA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int NumB = Convert.ToInt32(Console.ReadLine());

if(NumA > NumB)

{
    Console.Write("max = ");
    Console.WriteLine(NumA);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(NumB);
}
if (NumA == NumB)
Console.Write("Числа равны");