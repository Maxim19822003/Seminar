/*
8Напишите программу, которая выводит случайное число из отрезка 
[10, 99] и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8
*/

Random rand = new Random();
int number = rand.Next(10, 100);

Console.WriteLine($"Our random number is {number}");