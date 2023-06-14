/*Напишите программу, которая выводит
 случайное трехзначное число и 
 удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

Random rand = new Random();
int number = rand.Next(100, 1000);


int firstNum = number/100;
int secondNum = number%10;

Console.WriteLine($"Our random number is {number}");
Console.WriteLine($"First number is {firstNum}");
Console.WriteLine($"Second number is {secondNum}");
