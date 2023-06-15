/*
ВВодится трёхзначное число, выводится последнее, например:
875 -> 5
*/

Console.Write("Введите трёхзначное число: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(n % 10);