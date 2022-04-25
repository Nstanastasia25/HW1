//  Напишите программу, которая на вход принимает одно число (N), а на выходе показывает  
//все целые числа в промежутке от -N до N.

Console.Write("Введите N ");
double N = Convert.ToDouble(Console.ReadLine());
double A = -N + 1 ;
while (A>-N || A<N) 
{
    Console.WriteLine (A);
}
A = A + 1 ;