//Задача: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
[ex001](/[alt text]( "Описание будет тут")
int numberA = 4;
int numberB = 2;
int numberC = 22;
int max = numberA;
if (numberB>max) max=numberB;
if (numberC>max) max=numberC;
Console.Write("max=");
Console.WriteLine(max);
