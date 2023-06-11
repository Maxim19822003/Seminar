/*
Напишите программу,которая на вводе принимает
два числа, а на выходе даёт их квадрат.
Например:
4 -> 16
*/
Console.Write("Input number => ");
int number = Convert.ToInt32(Console.ReadLine());

int power = 2; // power of number
int squareNumber = Convert.ToInt32(Math.Pow(number, power));
Console.WriteLine($"Square {number} is {squareNumber}");

