/*
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число:");

number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)

     {

         Console.WriteLine("Число " + number + " нечётное");

    }

else
            
    {
         Console.WriteLine("Число " + number + "чётное");

    }
