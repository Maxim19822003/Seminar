/*
Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/

bool IsMultiplicity(int num)
{
    
    if(num%7==0 && num%23 ==0)
    {
        return true;
    }
    else
    {
        return false;
    }
  

}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = IsMultiplicity(num);
Console.WriteLine(result);
