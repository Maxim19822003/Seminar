/*
Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

using System;

namespace main

{

   class Program

   {

       static void Main(string[] args)

       {

           Console.WriteLine("Введите первое число:");

           int a = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Введите второе число:");

           int b = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");

       }

   }

}
