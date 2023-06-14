/*
Задача 10: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Second digit is {number/10%10}");
*/
/*
Random rand = new Random();
int number = rand.Next(100, 1000);

int firstNum = number/10;
int secondNum = firstNum%10;

Console.WriteLine($"Our random number is {number}");
Console.WriteLine($"Second digit is {secondNum}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6


/*
Console.Write("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());
string numStr = Convert.ToString(num);
int numDigit = numStr.Length;
    if (numDigit > 2) 
        Console.WriteLine($"Third digit is {numStr[2]}");
    else 
        Console.WriteLine("There is no third digit");
*/        

/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

/*
Console.Write("Enter the number of the day of the week "); 
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 6:
        Console.WriteLine("Yes");
        break;
    case 7:
        Console.WriteLine("Yes");
        break;
    default:
        Console.WriteLine("No");
        break;
}
*/