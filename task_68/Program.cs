/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/

int AckermanFunctions(int m, int n)
{
if (m == 0) return n + 1;
else if (m != 0 && n == 0) return AckermanFunctions(m - 1,1);
else return AckermanFunctions(m - 1,AckermanFunctions(m,n - 1));
}

Console.Write("Введите неотрицательное число M : ");
int First = int.Parse(Console.ReadLine());
if (First < 0)
{
    Console.Write("Заданное число отрицательное");
    return;
}
Console.Write("Введите неотрицательное число N: ");
int Second = int.Parse(Console.ReadLine());
if (Second < 0)
{
    Console.Write("Заданное число отрицательное");
    return;
}

Console.WriteLine($"A({First},{Second}) = {AckermanFunctions(First, Second)}");