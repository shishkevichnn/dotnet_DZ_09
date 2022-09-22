/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNaturalElements(int start, int end)
{
return start == end ? start: start + SumNaturalElements(start + 1, end);
}

Console.Write("Введите значение M : ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(SumNaturalElements(M, N));
