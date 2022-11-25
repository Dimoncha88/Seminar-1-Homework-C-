Console.Clear();

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A == B && B == C)
{
    Console.WriteLine("Числа равны");
}
else
{
int max = A;

 if(A > max) max = A;
 if(B > max) max = B;
 if(C > max) max = C;

 Console.Write("Наибольшее число: ");
 Console.WriteLine(max);
}