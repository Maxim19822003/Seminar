/*
Введите число: 8
-8 -7 -6 -5 -4 -3 -2 -1 0 1 2 3 4 5 6 7 8
*/

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
//int n1 = Convert.ToInt32(n * -1);
for (int i = -n; i <= n; i++)
{
    Console.Write($"{i} ");
}

