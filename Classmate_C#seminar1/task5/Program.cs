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


int firstNum = number/10;
int secondNum = number%10;

int answer = firstNum > secondNum ? firstNum : secondNum;

Console.WriteLine($"Our random number is {number}");
Console.WriteLine($"First number is {firstNum}");
Console.WriteLine($"Second number is {secondNum}");
Console.WriteLine($"Biger number is {answer}");
