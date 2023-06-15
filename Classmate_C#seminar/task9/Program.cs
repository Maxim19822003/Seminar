/*
Напишите программу, которая принимает на вход два числа
 и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

bool IsMultiplicity(int num1, int num2)
{
    
    if(num1 == num2*num2 || num2 == num1*num1)
    {
        return true;
    }
    else
    {
        return false;
    }
  

}

Console.Write("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = IsMultiplicity(num1,num2);
Console.WriteLine(result);