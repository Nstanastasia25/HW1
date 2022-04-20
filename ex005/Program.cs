//  Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
 Console.Write("Введите N");
double  N = Convert.ToDouble(Console.ReadLine());
double [] massiv = {-N,N} ;
if (-N > massiv > N) 
{
    Console.WriteLine (massiv);
}
else 
{
massiv = massiv + 1 ;
}
